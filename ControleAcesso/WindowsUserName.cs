using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso
{
    public class WindowsUserName
    {
        private WindowsIdentity _windowsUsername;
        public string IndetityUserName { get {
            return _windowsUsername.Name.Replace("\\","_");
            } 
        }
        public string DisplayName { get
            {
            return _windowsUsername.Name;
            } 
        }
        public WindowsUserName(System.Security.Principal.WindowsIdentity windowsIdentity)
        {
            // Get the Windows username
            _windowsUsername = windowsIdentity;
        }   
    }
}
