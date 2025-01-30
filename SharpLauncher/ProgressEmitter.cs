using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpLauncher
{
    internal class ProgressEmitter
    {
        Label stateLabel;
        ProgressBar mcProgressBar;
        Label percentageLabel;
        MinecraftLauncher launcher;

        public ProgressEmitter(Label stateLabel, ProgressBar mcProgressBar, Label percentageLabel, MinecraftLauncher launcher)
        {
            this.stateLabel = stateLabel;
            this.mcProgressBar = mcProgressBar;
            this.percentageLabel = percentageLabel;
            this.launcher = launcher;
            launcher.FileProgressChanged += async (sender, e) =>
            {
                await Task.Run(() =>
                {
                    stateLabel.Invoke((MethodInvoker)(() => stateLabel.Text = "Завантажую " + e.Name));

                });
            };

            launcher.ByteProgressChanged += async (sender, e) =>
            {
                await Task.Run(() =>
                {
                    var progress = (int)(e.ProgressedBytes * 100 / e.TotalBytes);
                    mcProgressBar.Invoke((MethodInvoker)(() => mcProgressBar.Value = progress));
                    percentageLabel.Invoke((MethodInvoker)(() => percentageLabel.Text = $"{progress}%"));
                });
            };
        }
    }
}
