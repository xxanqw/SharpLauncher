using CmlLib.Core.Java;
using CmlLib.Core;
using CmlLib.Core.ModLoaders.FabricMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace SharpLauncher.Installers
{
    internal class Fabric
    {
        Label stateLabel;
        ProgressBar mcProgressBar;
        Label percentageLabel;

        HttpClient httpClient = new HttpClient();

        public async Task Install(string version, Label stateLabel, ProgressBar mcProgressBar, Label percentageLabel)
        {
            this.stateLabel = stateLabel;
            this.mcProgressBar = mcProgressBar;
            this.percentageLabel = percentageLabel;

            var path = new FolderSpecification(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SharpLauncher", version);
            var parametrs = MinecraftLauncherParameters.CreateDefault(path);
            parametrs.JavaPathResolver = new MinecraftJavaPathResolver(path);
            parametrs.MinecraftPath = path;
            parametrs.MinecraftPath.Library = path.Library;
            parametrs.MinecraftPath.Versions = path.Versions;
            parametrs.MinecraftPath.Runtime = path.Runtime;
            parametrs.MinecraftPath.Assets = path.Assets;
            parametrs.MinecraftPath.Resource = path.Resource;
            parametrs.MinecraftPath.BasePath = path.BasePath;
            var launcher = new MinecraftLauncher(parametrs);
            ProgressEmitter progressEmitter = new ProgressEmitter(stateLabel, mcProgressBar, percentageLabel, launcher);

            var fabricInstaller = new FabricInstaller(httpClient);
            var versionName = await fabricInstaller.Install(version, path, $"Fabric {version}");
            await launcher.InstallAsync(versionName);
        }
    }
}
