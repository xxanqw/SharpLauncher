using CmlLib.Core.Java;
using CmlLib.Core;
using CmlLib.Core.Installer.Forge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core.Installer.Forge.Versions;

namespace SharpLauncher.Installers
{
    internal class Forge
    {
        Label stateLabel;
        ProgressBar mcProgressBar;
        Label percentageLabel;

        public async Task Install(string version, string forgeVersion, Label stateLabel, ProgressBar mcProgressBar, Label percentageLabel)
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

            var forgeInstaller = new ForgeInstaller(launcher);
            var versionName = await forgeInstaller.Install(version, forgeVersion);
            await launcher.InstallAsync(versionName);
        }
    }
}
