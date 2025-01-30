using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Auth.Microsoft.Sessions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SharpLauncher
{
    public partial class AuthWindow : Form
    {
        private static AccountManagers.Microsoft microsoft;

        public AuthWindow()
        {
            InitializeComponent();
            LoadAccounts();
            microsoft = new AccountManagers.Microsoft();
        }

        private void LoadAccounts()
        {
            var loginHandler = JELoginHandlerBuilder.BuildDefault();
            var accounts = loginHandler.AccountManager.GetAccounts();
            foreach(var account in accounts)
            {
                if (!(account is JEGameAccount jeAccount))
                    continue;
                accountsList.Items.Add(jeAccount.Profile?.Username);
            };
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //int targetWidth = 317;
            //int step = 5;
            //while (this.Width < targetWidth)
            //{
            //    this.Width += step;
            //    await Task.Delay(10); // Adjust delay for smoother animation
            //}
            //this.Width = targetWidth; // Ensure final width is set
            microsoft.Login();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        async private void iconButton2_Click(object sender, EventArgs e)
        {
            if (accountsList == null || accountsList.SelectedIndex < 0)
            {
                MessageBox.Show("Ви не обрали, акаунт!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var loginHandler = JELoginHandlerBuilder.BuildDefault();
            var accounts = loginHandler.AccountManager.GetAccounts();
            var selectedAccount = accounts.ElementAt(accountsList.SelectedIndex);
            await loginHandler.SignoutWithBrowser(selectedAccount);
        }
    }
}
