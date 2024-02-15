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
        private string _userName;
        private WindowsIdentity _windowsUsername;
        private string _text;

        public string IndetityUserName { get {
            return _userName.Replace("\\","_");
            } 
        }
        public string DisplayName { get
            {
            return _userName.Replace("_","\\");
            } 
        }
        public WindowsUserName(System.Security.Principal.WindowsIdentity windowsIdentity)
        {
            // Get the Windows username
            _windowsUsername = windowsIdentity;
            _userName = windowsIdentity.Name;
        }

        public WindowsUserName(string text)
        {
            this._text = text;
            _userName = _text;
        }
    }
}
