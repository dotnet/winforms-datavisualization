/* fixformat ignore:start */
#addin "Cake.FileHelpers"
/* fixformat ignore:end */

#region Constants

string Prepare = "Prepare";
string PrepareNuget = "Prepare-Nuget";
string Default = "Default";

#endregion

#region Arguments

string target = Argument("target", "Default");
string config = Argument("config", "Debug");
string version = Argument("vers", "1.0.0.0");
string solutionDirectory = Argument("solution-directory", "");
string solutionFilename = Argument("solution-filename", "DataViz.sln");
string outdir = Argument("out-dir", "");

string[] projects = new string[]
{
  System.IO.Path.Combine("src", "System.Windows.Forms.DataVisualization", "ChartWin.csproj")
};

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
    string solutionFile = System.IO.Path.Combine(solutionDirectory, solutionFilename);

    string versionNum = version + "-" + config.ToLower();
    if (config.ToLower() == "release")
      versionNum = version;

    DotNetCoreMSBuild(solutionFile, new DotNetCoreMSBuildSettings()
      .SetConfiguration(config)
      .WithTarget("CleanObjAndBin")
      .WithProperty("SolutionDir", solutionDirectory)
      .WithProperty("SolutionFileName", solutionFilename)
      .WithProperty("Version", versionNum));

    DotNetCoreMSBuild(solutionFile, new DotNetCoreMSBuildSettings()
      .SetConfiguration(config)
      .WithTarget("Clean")
      .WithProperty("SolutionDir", solutionDirectory)
      .WithProperty("SolutionFileName", solutionFilename)
      .WithProperty("Version", versionNum));

    DotNetCoreMSBuild(solutionFile, new DotNetCoreMSBuildSettings()
      .SetConfiguration(config)
      .WithTarget("Restore")
      .WithProperty("SolutionDir", solutionDirectory)
      .WithProperty("SolutionFileName", solutionFilename)
      .WithProperty("Version", versionNum)
    );

    DotNetCoreMSBuild(solutionFile, new DotNetCoreMSBuildSettings()
      .SetConfiguration(config)
      .WithTarget("Build")
      .WithProperty("SolutionDir", solutionDirectory)
      .WithProperty("SolutionFileName", solutionFilename)
      .WithProperty("Version", versionNum)
    );

    DotNetCoreBuildSettings settings = new DotNetCoreBuildSettings();
    settings.Configuration = config;

    foreach (var proj in projects)
    {
      DotNetCorePackSettings settings1 = new DotNetCorePackSettings();
      settings1.Configuration = config;
      settings1.NoBuild = true;
      settings1.NoRestore = true;
      settings1.OutputDirectory = outdir;
      if (config.ToLower() == "debug")
      {
        settings1.IncludeSource = true;
        settings1.IncludeSymbols = true;
      }

      settings1.MSBuildSettings = new DotNetCoreMSBuildSettings()
        .WithProperty("SolutionDir", solutionDirectory)
        .WithProperty("SolutionFileName", solutionFilename)
        .WithProperty("Version", versionNum);

      DotNetCorePack(System.IO.Path.Combine(solutionDirectory, proj), settings1);
    }

  });

#endregion

// Task("setup-connectors-temporal-task")
//   .IsDependentOn("Prepare")
//   .Does(() =>
//   {
//     ReplaceRegexInFiles(System.IO.Path.Combine(solutionDirectory, csprojCore),
//       "<TargetFrameworks>.*<\\/TargetFrameworks>",
//       "<TargetFrameworks>netstandard2.0</TargetFrameworks>");
//   });

RunTarget(target);
