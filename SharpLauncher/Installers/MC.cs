using CmlLib.Core.Java;
using CmlLib.Core;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core.Installers;
using System.Net.Http;

namespace SharpLauncher.Installers
{
    internal class MC
    {
        Label stateLabel;
        ProgressBar mcProgressBar;
        Label percentageLabel;

        public async Task Install(string version, Label stateLabel, ProgressBar mcProgressBar, Label percentageLabel)
        {
            this.stateLabel = stateLabel;
            this.mcProgressBar = mcProgressBar;
            this.percentageLabel = percentageLabel;

            var path = new FolderSpecification(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SharpLauncher", version);
            var parameters = MinecraftLauncherParameters.CreateDefault(path);
            parameters.JavaPathResolver = new MinecraftJavaPathResolver(path);
            parameters.MinecraftPath = path;
            parameters.MinecraftPath.Library = path.Library;
            parameters.MinecraftPath.Versions = path.Versions;
            parameters.MinecraftPath.Runtime = path.Runtime;
            parameters.MinecraftPath.Assets = path.Assets;
            parameters.MinecraftPath.Resource = path.Resource;
            parameters.MinecraftPath.BasePath = path.BasePath;

            if (Properties.Settings.Default.QuickDownload)
            {
                parameters.GameInstaller = ParallelGameInstaller.CreateAsCoreCount(new HttpClient());
            }
            else
            {
                parameters.GameInstaller = new BasicGameInstaller(new HttpClient());
            }

            var launcher = new MinecraftLauncher(parameters);
            ProgressEmitter progressEmitter = new ProgressEmitter(stateLabel, mcProgressBar, percentageLabel, launcher);
            int retries = 10;

            while (retries > 0)
            {
                try
                {
                    await launcher.InstallAsync(version);
                    break;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("429") && retries > 1)
                    {
                        retries--;
                        await Task.Delay(2000);
                    }
                    else
                    {
                        MessageBox.Show($"Виникла помилка: {ex.Message}");
                        break;
                    }
                }
            }
        }
    }
}