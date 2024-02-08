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
            // Use the Windows username to open the system
            // TODO: Implement your logic here

            // Save the user to the database using Identity
            var userManager = _serviceProvider.GetRequiredService<UserManager<Usuario>>();
            var user = new Usuario(_windowsUsername.IndetityUserName);
            // Verify if user exists in the database, if not create it

            var result = await userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                // Handle error
            }

        }
    }
}