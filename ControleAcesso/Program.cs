using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Security.Principal;

namespace ControleAcesso
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            WindowsUserName windowsUserName = new WindowsUserName(WindowsIdentity.GetCurrent());

            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>();

            services.AddIdentityCore<Usuario>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            var serviceProvider = services.BuildServiceProvider();

            Application.Run(new Form1(windowsUserName, serviceProvider));
        }
    }
}