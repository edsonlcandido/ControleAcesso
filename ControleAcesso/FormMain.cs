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
        private bool _isAdmin
        {
            get
            {
                //verifica se o _windowsUsername é administrador
                var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
                var user = userManager.Users.Where(u => u.NormalizedUserName == _windowsUsername.IndetityUserName.ToUpper()).FirstOrDefault();
                //verifica se o usuario é administrador
                return userManager.IsInRoleAsync(user, "ADMIN").Result;

            }
        }

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


            List<dataViewUsers> dataViewUsers = users.Select(u => new dataViewUsers { Id = u.Id, DisplayName = u.DisplayName }).ToList();
            List<dataViewRoles> dataViewRoles = roles.Select(r => new dataViewRoles { Id = r.Id, DisplayName = r.NormalizedName }).ToList();

            dataGridViewUsers.DataSource = dataViewUsers;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRoles.DataSource = dataViewRoles;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            flowLayoutPanelAdminControls.Visible = _isAdmin;
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

        private void buttonUserDetails_Click(object sender, EventArgs e)
        {
            dataViewUsers selectedUser = (dataViewUsers)dataGridViewUsers.CurrentRow.DataBoundItem;

            //obter os roles do usuario
            var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
            var user = userManager.Users.Where(u => u.Id == selectedUser.Id).FirstOrDefault();
            var roles = userManager.GetRolesAsync(user).Result;
            flowLayoutPanelUserRoles.Controls.Clear();
            if (roles.Count > 0)
            {
                flowLayoutPanelUserRoles.Controls.Add(new Label() { Text = "Funções do usuário", AutoSize = true });
                foreach (var role in roles)
                {
                    flowLayoutPanelUserRoles.Controls.Add(new Label() { Text = role });
                }
            }
            else
            {
                flowLayoutPanelUserRoles.Controls.Add(new Label() { Text = "Usuário sem funções", AutoSize = true });
            }

        }

        private void buttonAddRoleToUser_Click(object sender, EventArgs e)
        {
            //adicionar a função ao usuario
            dataViewUsers selectedUser = (dataViewUsers)dataGridViewUsers.CurrentRow.DataBoundItem;
            dataViewRoles selectedRole = (dataViewRoles)dataGridViewRoles.CurrentRow.DataBoundItem;

            // Adicione aqui a lógica para adicionar a função ao usuário selecionado
            var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
            var user = userManager.Users.Where(u => u.Id == selectedUser.Id).FirstOrDefault();
            var result = userManager.AddToRoleAsync(user, selectedRole.DisplayName).Result;
            if (result.Succeeded)
            {
                var roles = userManager.GetRolesAsync(user).Result;
                flowLayoutPanelUserRoles.Controls.Clear();
                if (roles.Count > 0)
                {
                    flowLayoutPanelUserRoles.Controls.Add(new Label() { Text = "Funções do usuário", AutoSize = true });
                    foreach (var role in roles)
                    {
                        flowLayoutPanelUserRoles.Controls.Add(new Label() { Text = role, AutoSize = true });
                    }
                }
                else
                {
                    flowLayoutPanelUserRoles.Controls.Add(new Label() { Text = "Usuário sem funções", AutoSize = true });
                }
            }
        }
    }
    public class dataViewUsers
    {
        //hidden id from datagridview binding
        [Browsable(false)] // or [System.ComponentModel.DataAnnotations.Schema.NotMapped] or [System.Text.Json.Serialization.JsonIgnore] or [Newtonsoft.Json.JsonIgnore] or [System.Xml.Serialization.XmlIgnore] or [System.Xml.Serialization.XmlIgnoreAttribute] or [System.Xml.Serialization.XmlIgnoreAttribute()] or [System.Xml.Serialization.XmlIgnoreAttribute]   
        public string Id { get; set; }
        [DisplayName("Usuário")]
        public string DisplayName { get; set; }
    }
    public class dataViewRoles
    {
        //hidden id from datagridview binding
        [Browsable(false)]
        public string Id { get; set; }
        [DisplayName("Função")]
        public string DisplayName { get; set; }
    }
}