using CmlLib.Core.Auth.Microsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLauncher.AccountManagers
{
    internal class Microsoft
    {
        public void Login()
        {
            var loginHandler = JELoginHandlerBuilder.BuildDefault();
            loginHandler.AuthenticateInteractively();
        }
    }
}
