/* fixformat ignore:start */
#addin "Cake.FileHelpers"
/* fixformat ignore:end */

using Path = System.IO.Path;

#region Constants

const string Prepare = "Prepare";
const string PrepareNuget = "Prepare-Nuget";
const string Default = "Default";

#endregion

#region Arguments

string target = Argument("target", "Default");
string config = Argument("config", "Debug");
string version = Argument("vers", "1.0.0.0");
string solutionDirectory = Argument("solution-directory", "");
string solutionFilename = Argument("solution-filename", "DataViz.sln");
string outdir = Argument("out-dir", "");

#endregion Arguments

#region Prepare
Task(Prepare)
  .Does(() =>
  {

    if (String.IsNullOrWhiteSpace(solutionDirectory))
    {
      var dir = System.IO.Directory.GetCurrentDirectory();

      try
      {
        for (int i = 0; i < 6; i++)
        {
          var find_path = System.IO.Path.Combine(dir, solutionFilename);
          if (System.IO.File.Exists(find_path))
          {
            solutionDirectory = dir;
            break;
          }
          dir = System.IO.Path.GetDirectoryName(dir);
        }
      }
      catch
      {

      }
    }
    if (String.IsNullOrWhiteSpace(solutionDirectory))
      throw new FileNotFoundException($"File `{solutionFilename}` was not found!");
    solutionDirectory = System.IO.Path.GetFullPath(solutionDirectory);
    if (!solutionDirectory.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()))
      solutionDirectory += System.IO.Path.DirectorySeparatorChar.ToString();

  });

Task(PrepareNuget)
  .IsDependentOn(Prepare)
  .Does(() =>
  {
    if (String.IsNullOrWhiteSpace(outdir))
    {
      outdir = System.IO.Path.Combine(solutionDirectory, "..", "fr_nuget");
    }
    else if (!System.IO.Path.IsPathRooted(outdir))
    {
      outdir = System.IO.Path.Combine(solutionDirectory, "..", outdir);
    }

    if (!System.IO.Directory.Exists(outdir))
      System.IO.Directory.CreateDirectory(outdir);
  });


Task(Default)
  .IsDependentOn(Prepare)
  .Does(() =>
  {
    Information("Use: ");
    Information("   --name=value");

    Information("");

    Information("|>  --target=" + target + " change task, see the task with command cake -tree. Core, Plugins, Test-Connectors.");
    Information("|>  --config=" + config + " change config. Debug, Release, Demo. ");
    Information("|>  --vers=" + version + " change version");
    Information("|>  --solution-directory=" + solutionDirectory + " change solution directory");
    Information("|>  --solution-filename=" + solutionFilename + " change solution file name");
  });

#endregion Prepare

#region DataVisualization

Task("DataVisualization")
  .IsDependentOn(Prepare)
  .IsDependentOn(PrepareNuget)
  .Does(() =>
  {
    const string tfmCore30 = ".NETCoreApp3.0";
    const string tfmNet5 = "net5.0-windows7.0";
    const string tfmNet40 = ".NETFramework4.0";

    string solutionFile = System.IO.Path.Combine(solutionDirectory, solutionFilename);
    string usedPackagesVersionPath = Path.Combine(solutionDirectory, "UsedPackages.version");

    string nugetDir = Path.Combine(solutionDirectory, "bin", "nuget");

    // Clean nuget directory for package
    if (DirectoryExists(nugetDir))
    {
      DeleteDirectory(nugetDir, new DeleteDirectorySettings{
        Force = true, 
        Recursive = true
      });
    }

    TargetBuildCore("Clean");

    TargetBuildCore("Restore");

    TargetBuildCore("Build");

    TargetBuildCore("PrepareDataVisPackage");

    // Remove FastReport.Compat library
    DeleteFiles(Path.Combine(nugetDir, "**" , "FastReport.Compat.dll"));

    // Get used packages version
    string FRCompatVersion = XmlPeek(usedPackagesVersionPath, "//FRCompatVersion/text()");
    Information($"FRCompatVersion: {FRCompatVersion}");
    string SystemDrawingCommonVersion = XmlPeek(usedPackagesVersionPath, "//SystemDrawingCommonVersion/text()");
    Information($"System.Drawing.Common version: {SystemDrawingCommonVersion}");
    string SystemDataSqlClientVersion = XmlPeek(usedPackagesVersionPath, "//SystemDataSqlClientVersion/text()");
    Information($"System.Data.SqlClient version: {SystemDataSqlClientVersion}");


    var dependencies = new List<NuSpecDependency>();
    AddNuSpecDep("FastReport.Compat", FRCompatVersion, tfmNet40);
    AddNuSpecDepCore("FastReport.Compat", FRCompatVersion);
    AddNuSpecDepCore("System.Drawing.Common", SystemDrawingCommonVersion);
    AddNuSpecDepCore("System.Data.SqlClient", SystemDataSqlClientVersion);

    var files = new[] {
       new NuSpecContent{Source = Path.Combine(nugetDir, "**", "*.*"), Target = ""},
    };


    var nuGetPackSettings = new NuGetPackSettings {
        Id                      = "FastReport.DataVisualization",
        Version                 = version,
        Authors                 = new[] {"Fast Reports Inc."},
        Owners                  = new[] {"Fast Reports Inc."},
        Description             = "Charting library",
        Repository              = new NuGetRepository{Type = "GIT", Url = "https://github.com/FastReports/winforms-datavisualization"},
        ProjectUrl              = new Uri("https://www.fast-report.com/en/product/fast-report-net"),
        Icon                    = "frlogo-big.png",  // Property Icon available since Cake 1.0
        IconUrl                 = new Uri("https://raw.githubusercontent.com/FastReports/FastReport.Compat/master/frlogo-big.png"),
        ReleaseNotes            = new[] { "See the latest changes on https://github.com/FastReports/winforms-datavisualization"},
        License                 = new NuSpecLicense {Type = "file", Value = "LICENSE.txt"},
        Copyright               = "Fast Reports Inc.",
        Tags                    = new [] {"Chart", "WinForms", "Windows Forms DataVisualization", "DataVisualisation", "Data", "Visualization"},
        RequireLicenseAcceptance= true,
        Symbols                 = false,
        NoPackageAnalysis       = true,
        Files                   = files,
        Dependencies            = dependencies,
        BasePath                = nugetDir,
        OutputDirectory         = outdir
    };

    // Pack
    NuGetPack(Path.Combine(solutionDirectory, "Nuget", "FastReport.DataVisualization.nuspec"), nuGetPackSettings);


    // Local functions:

    // For Net Standard 2.0, Core 3.0 and Net 5.0
    void AddNuSpecDepCore(string id, string version)
    {
      AddNuSpecDep(id, version, ".NETStandard2.0");
      AddNuSpecDep(id, version, tfmCore30);
      AddNuSpecDep(id, version, tfmNet5);
    }

    void AddNuSpecDep(string id, string version, string tfm)
    {
      dependencies.Add(new NuSpecDependency{Id = id, Version = version, TargetFramework = tfm});
    }

    void TargetBuildCore(string target)
    {
      DotNetCoreMSBuild(solutionFile, new DotNetCoreMSBuildSettings()
        .SetConfiguration(config)
        .WithTarget(target)
        .WithProperty("SolutionDir", solutionDirectory)
        .WithProperty("SolutionFileName", solutionFilename)
        .WithProperty("Version", version)
      );
    }

  });

#endregion

RunTarget(target);
