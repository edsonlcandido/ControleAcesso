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
        [DisplayName("Usuario")]
        public override string UserName { get => base.UserName; set => base.UserName = value; }
    }
}
