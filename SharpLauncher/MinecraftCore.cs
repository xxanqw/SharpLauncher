using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.VersionMetadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using CmlLib.Core.ProcessBuilder;
using System.Diagnostics;
using CmlLib.Core.FileExtractors;
using CmlLib.Core.Java;
using System.Security.Cryptography;
using CmlLib.Core.ModLoaders.FabricMC;
using System.Net.Http;
using SharpLauncher.Installers;
using Newtonsoft.Json;
using System.IO;
using CmlLib.Core.Auth.Microsoft;

namespace SharpLauncher
{
    internal class MinecraftCore
    {
        private static string version;
        private static FolderSpecification path;
        public static MinecraftLauncher launcher;

        private static Label stateLabel;
        private static ProgressBar mcProgressBar;
        private static Label percentageLabel;

        private static MC MC = new MC();
        private static Fabric Fabric = new Fabric();
        private static Forge Forge = new Forge();

        public static Process process;

        public MinecraftCore(Label stateLabel, ProgressBar mcProgressBar, Label percentageLabel)
        {
            MinecraftCore.stateLabel = stateLabel;
            MinecraftCore.mcProgressBar = mcProgressBar;
            MinecraftCore.percentageLabel = percentageLabel;

            path = new FolderSpecification(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SharpLauncher", version);
            var parametrs = MinecraftLauncherParameters.CreateDefault(path);
            parametrs.JavaPathResolver = new MinecraftJavaPathResolver(path);
            parametrs.MinecraftPath = path;
            parametrs.MinecraftPath.Library = path.Library;
            parametrs.MinecraftPath.Versions = path.Versions;
            parametrs.MinecraftPath.Runtime = path.Runtime;
            parametrs.MinecraftPath.Assets = path.Assets;
            parametrs.MinecraftPath.Resource = path.Resource;
            parametrs.MinecraftPath.BasePath = path.BasePath;
            launcher = new MinecraftLauncher(parametrs);
        }

        public async Task<VersionMetadataCollection> GetMinecraftVersions()
        {
            try
            {
                var versions = await launcher.GetAllVersionsAsync();
                return versions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
                return null;
            }
        }

        public async Task InstallMinecraft(string version)
        {
            try
            {
                await MC.Install(version, stateLabel, mcProgressBar, percentageLabel);
                SaveInstalledVersion(version);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
            }
        }

        public async Task InstallFabric(string version)
        {
            try
            {
                await Fabric.Install(version, stateLabel, mcProgressBar, percentageLabel);
                SaveInstalledVersion(version);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
            }
        }

        public async Task InstallForge(string version, string forgeVersion)
        {
            try
            {
                await Forge.Install(version, forgeVersion, stateLabel, mcProgressBar, percentageLabel);
                SaveInstalledVersion(version);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
            }
        }

        public bool CheckInstallation(string version)
        {
            try
            {
                var installedVersions = GetInstalledVersions();
                if (installedVersions.Contains(version))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
                return false;
            }
        }

        private void SaveInstalledVersion(string version)
        {
            var installedVersions = GetInstalledVersions();
            if (!installedVersions.Contains(version))
            {
                installedVersions.Add(version);
                File.WriteAllText(Path.Combine(path.BasePath, "versions.json"), JsonConvert.SerializeObject(installedVersions));
            }
        }

        private List<string> GetInstalledVersions()
        {
            var filePath = Path.Combine(path.BasePath, "versions.json");
            if (File.Exists(filePath))
            {
                return JsonConvert.DeserializeObject<List<string>>(File.ReadAllText(filePath));
            }
            return new List<string>();
        }

        public async Task<Process> StartMinecraft(string version, MSession session)
        {
            try
            {
                string jarPath = path.GetVersionJarPath(version);
                string instancePath = path.GetDirectoryName(version);

                var launchOption = new MLaunchOption
                {
                    GameLauncherName = "SharpLauncher",
                    GameLauncherVersion = "1.0.0",
                    MaximumRamMb = Properties.Settings.Default.Memory,
                    MinimumRamMb = 512,
                    Session = session,
                    ArgumentDictionary = new Dictionary<string, string>
                            {
                                { "natives_directory", path.GetNativePath(version) },
                                { "launcher_name", "SharpLauncher" },
                                { "launcher_version", "1" },
                                { "game_directory", instancePath }
                            },
                    ExtraJvmArguments = new MArgument[]
                    {
                                new MArgument($"-Djava.library.path={path.GetNativePath(version)}"),
                                new MArgument($"-Dminecraft.client.jar={jarPath}")
                    }
                };

                if (Properties.Settings.Default.AutoServerJoin)
                {
                    launchOption.ServerIp = Properties.Settings.Default.ServerAdress;
                    launchOption.ServerPort = Properties.Settings.Default.ServerPort;
                }

                if (Properties.Settings.Default.WindowResolutionOverwrite)
                {
                    launchOption.ScreenWidth = Properties.Settings.Default.WindowWidth;
                    launchOption.ScreenHeight = Properties.Settings.Default.WindowHeight;
                }

                if (Properties.Settings.Default.Fullscreen)
                {
                    launchOption.FullScreen = Properties.Settings.Default.Fullscreen;
                }

                process = await launcher.CreateProcessAsync(version, launchOption);
                process.StartInfo.WorkingDirectory = instancePath; 
                process.Start();

                return process;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");

                return null;
            }
        }
    }
}