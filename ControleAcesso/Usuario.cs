using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso
{
    public class Usuario : IdentityUser
    {
        public Usuario(string userName) : base(userName)
        {
        }        
        public override string UserName { get => base.UserName; set => base.UserName = value; }
        [DisplayName("Usuario")]
        public string DisplayName { get { 
                return this.NormalizedUserName.Replace("_","\\"); 
            } 
        }
    }
}
