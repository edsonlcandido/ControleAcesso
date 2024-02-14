using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;

namespace ControleAcesso
{
    public partial class Form1 : Form
    {
        private WindowsUserName _windowsUsername;
        private ServiceProvider _serviceProvider;

        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        public Form1(WindowsUserName windowsUsername, ServiceProvider serviceProvider)
        {
            this._windowsUsername = windowsUsername;
            this._serviceProvider = serviceProvider;
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            //obter a lista de usuarios do banco de dados
            var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
            var users = userManager.Users.ToList();

            var rolesManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = rolesManager.Roles.ToList();

            dataGridViewUsers.DataSource = users;
            dataGridViewRoles.DataSource = roles;
        }
    }
}