using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;

namespace ControleAcesso
{
    public partial class FormMain : Form
    {
        private WindowsUserName _windowsUsername;
        private ServiceProvider _serviceProvider;

        public FormMain()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        public FormMain(WindowsUserName windowsUsername, ServiceProvider serviceProvider)
        {
            this._windowsUsername = windowsUsername;
            this._serviceProvider = serviceProvider;
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //obter a lista de usuarios do banco de dados
            var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
            var users = userManager.Users.ToList();

            var rolesManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = rolesManager.Roles.ToList();


            List<dataViewUsers> dataViewUsers = users.Select(u => new dataViewUsers { DisplayName = u.DisplayName }).ToList();
            List<dataViewRoles> dataViewRoles = roles.Select(r => new dataViewRoles { DisplayName = r.NormalizedName }).ToList();

            dataGridViewUsers.DataSource = dataViewUsers;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRoles.DataSource = dataViewRoles;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {

        }

        private async void buttonAddRole_Click(object sender, EventArgs e)
        {
            //adicionar a função aos roles do identity
            var rolesManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var role = new IdentityRole(textBoxAddRole.Text);
            var result = await rolesManager.CreateAsync(role);
            if (result.Succeeded)
            {
                var roles = rolesManager.Roles.ToList();
                List<dataViewRoles> dataViewRoles = roles.Select(r => new dataViewRoles { DisplayName = r.NormalizedName }).ToList();
                dataGridViewRoles.DataSource = dataViewRoles;
            }

        }

        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            //adicionar o usuario ao banco de dados
            var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
            WindowsUserName windowsUserName = new(textBoxAddUser.Text);
            var user = new Usuario(windowsUserName.IndetityUserName);
            var result = await userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                var users = userManager.Users.ToList();
                List<dataViewUsers> dataViewUsers = users.Select(u => new dataViewUsers { DisplayName = u.DisplayName }).ToList();
                dataGridViewUsers.DataSource = dataViewUsers;
            }
        }
    }
    public class dataViewUsers
    {
        [DisplayName("Usuário")]
        public string DisplayName { get; set; }
    }
    public class dataViewRoles
    {
        [DisplayName("Função")]
        public string DisplayName { get; set; }
    }
}