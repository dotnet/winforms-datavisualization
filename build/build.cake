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

    DotNetCoreMSBuild(solutionFile, new DotNetCoreMSBuildSettings()
      .SetConfiguration(config)
      .WithTarget("PrepareDataVisPackage")
      .WithProperty("SolutionDir", solutionDirectory)
      .WithProperty("SolutionFileName", solutionFilename)
      .WithProperty("Version", versionNum)
    );


    string nuget = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "tools", "nuget.exe");
    string nuspec = System.IO.Path.Combine(solutionDirectory, "bin", "nuget", "FastReport.DataVisualization.nuspec");
    string arguments = $"pack {nuspec} -OutputDirectory \"{outdir}\" -Version {versionNum}";
    StartProcess(nuget, arguments);

  });

#endregion

RunTarget(target);
