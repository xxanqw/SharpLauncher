using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace SharpLauncher
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            LoadBG();
            this.Icon = Properties.Resources.sllogo;

            memoryUpDown.Value = Properties.Settings.Default.Memory;
            portBox.Controls[0].Visible = false;
            widthBox.Controls[0].Visible = false;
            heightBox.Controls[0].Visible = false;

            connectToServerCheckBox.Checked = Properties.Settings.Default.AutoServerJoin;
            windowResolutionChangeCheckBox.Checked = Properties.Settings.Default.WindowResolutionOverwrite;
            widthBox.Enabled = Properties.Settings.Default.WindowResolutionOverwrite;
            heightBox.Enabled = Properties.Settings.Default.WindowResolutionOverwrite;
            ipBox.Enabled = Properties.Settings.Default.AutoServerJoin;
            portBox.Enabled = Properties.Settings.Default.AutoServerJoin;

            widthBox.Value = Properties.Settings.Default.WindowWidth;
            heightBox.Value = Properties.Settings.Default.WindowHeight;
            ipBox.Text = Properties.Settings.Default.ServerAdress;
            portBox.Value = Properties.Settings.Default.ServerPort;
            fullScreenCheckBox.Checked = Properties.Settings.Default.Fullscreen;
            quickDownloadCheckBox.Checked = Properties.Settings.Default.QuickDownload;
        }

        private void LoadBG()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LauncherBackground))
            {
                Image bg = Image.FromFile(Properties.Settings.Default.LauncherBackground);
                bgPreview.Image = bg;
                return;
            }
            else
            {
                bgPreview.Image = Properties.Resources.defaultbg;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chooseBG.ShowDialog() == DialogResult.OK)
            {
                string filepath = chooseBG.FileName;

                Properties.Settings.Default.LauncherBackground = filepath;
                Properties.Settings.Default.Save();
                Image bg = Image.FromFile(filepath);
                bgPreview.Image = bg;
            }
        }

        private void memoryUpDown_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Memory = (int)memoryUpDown.Value;
        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SharpLauncher";
            var psi = new ProcessStartInfo();
            psi.FileName = @"c:\windows\explorer.exe";
            psi.Arguments = folder;
            Process.Start(psi);
        }

        private void connectToServerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (connectToServerCheckBox.Checked)
            {
                ipBox.Enabled = true;
                portBox.Enabled = true;

            }
            else
            {
                ipBox.Enabled = false;
                portBox.Enabled = false;
            }
            Properties.Settings.Default.AutoServerJoin = connectToServerCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerAdress = ipBox.Text;
            Properties.Settings.Default.Save();
        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPort = (int)portBox.Value;
            Properties.Settings.Default.Save();
        }

        private void windowResolutionChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (windowResolutionChangeCheckBox.Checked)
            {
                widthBox.Enabled = true;
                heightBox.Enabled = true;
            }
            else
            {
                widthBox.Enabled = false;
                heightBox.Enabled = false;
            }
            Properties.Settings.Default.WindowResolutionOverwrite = windowResolutionChangeCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void widthBox_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPort = (int)widthBox.Value;
            Properties.Settings.Default.Save();
        }

        private void heightBox_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPort = (int)heightBox.Value;
            Properties.Settings.Default.Save();
        }

        private void resetBGButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Точно скинути фон лаунчеру?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bgPreview.Image = Properties.Resources.defaultbg;
                Properties.Settings.Default.LauncherBackground = "";
                Properties.Settings.Default.Save();
            }
        }

        private void quickDownloadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.QuickDownload = quickDownloadCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void fullScreenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Fullscreen = fullScreenCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
