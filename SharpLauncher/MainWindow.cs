using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Auth.Microsoft.Authenticators;
using CmlLib.Core.Auth.Microsoft.Sessions;
using CmlLib.Core.VersionMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using XboxAuthNet.Game.Accounts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SharpLauncher
{
    public partial class MainWindow : Form
    {
        private MinecraftCore core;

        private VersionMetadataCollection versions;

        private JELoginHandler loginHandler;
        private XboxGameAccountCollection accounts;
        

        public MainWindow()
        {
            InitializeComponent();
            core = new MinecraftCore(stateLabel, mcProgressBar, percentageLabel);
            InitUI();
        }

        private void InitUI()
        {
            LoadBG();
            Properties.Settings.Default.PropertyChanged += UpdateUI;
            LoadAccounts();
            LoadVersions();
        }

        private void UpdateUI(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "LauncherBackground")
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.LauncherBackground))
                {
                    Image bg = Image.FromFile(Properties.Settings.Default.LauncherBackground);
                    this.BackgroundImage = bg;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.defaultbg;
                }
            }
        }

        private void LoadBG()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LauncherBackground))
            {
                try
                {
                    Image bg = Image.FromFile(Properties.Settings.Default.LauncherBackground);
                    this.BackgroundImage = bg;
                }
                catch (Exception)
                {
                    MessageBox.Show($"Виникла помилка при встановлені зображеня фону лаунчеру, відкат до стандартного\nМожливо файлу який був встановлений більше не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackgroundImage = Properties.Resources.defaultbg;
                    Properties.Settings.Default.LauncherBackground = "";
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.defaultbg;
            }
        }

        async private void LoadVersions()
        {
            versions = await core.GetMinecraftVersions();
            foreach (var version in versions)
            {
                versionBox.Items.Add(version.Name);
            }
            versionBox.SelectedIndex = Properties.Settings.Default.LastVersionSelected;
        }

        private void LoadAccounts()
        {
            loginHandler = JELoginHandlerBuilder.BuildDefault();
            accounts = loginHandler.AccountManager.GetAccounts();
            foreach (var account in accounts)
            {
                if (!(account is JEGameAccount jeAccount))
                {
                    continue;
                }
                accountsBox.Items.Add(jeAccount.Profile?.Username);
            }
            accountsBox.Items.Add("Додати акаунт");
            accountsBox.SelectedIndex = Properties.Settings.Default.LastAccountSelected;
        }

        async private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                progressPanel.Visible = true;
                stateLabel.Text = "Перевірка інсталяції...";
                mcProgressBar.Style = ProgressBarStyle.Marquee;
                if (!core.CheckInstallation(versionBox.Text))
                {
                    mcProgressBar.Style = ProgressBarStyle.Blocks;
                    await core.InstallMinecraft(versionBox.Text);
                }
                mcProgressBar.Style = ProgressBarStyle.Marquee;
                percentageLabel.Visible = false;
                stateLabel.Text = "Запуск гри...";
                var selectedAccount = accounts.GetJEAccountByUsername(accountsBox.Text);
                var session = await loginHandler.Authenticate(selectedAccount);
                var process = await core.StartMinecraft(versionBox.Text, session);
                playButton.Enabled = false;
                progressPanel.Visible = false;
                process.WaitForExit();
                playButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void accountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountsBox.SelectedItem != null)
            {
                if (accountsBox.Text == "Додати акаунт")
                {
                    AuthWindow authWindow = new AuthWindow();
                    authWindow.ShowDialog();
                    // After closing auth window - set the selected item to null, so you can reselect this option
                    accountsBox.SelectedItem = null;
                }
                else
                {
                    Properties.Settings.Default.LastAccountSelected = accountsBox.SelectedIndex;
                    Properties.Settings.Default.Save();;
                }
            }
        }

        private void versionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (versionBox.SelectedItem != null)
            {
                Properties.Settings.Default.LastVersionSelected = versionBox.SelectedIndex;
                Properties.Settings.Default.Save();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
    }
}
