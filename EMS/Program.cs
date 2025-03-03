using EMS.Data;
using EMS.Services;
using EMS.Services.Interfaces;
using EMS.UI;
using EMS.UI.Interfaces;
using EMS.Utilities;
using EMS.Utilities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Project.EmployeeManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();

            var menuRunner = host.Services.GetRequiredService<IMenuRunner>();
            menuRunner.RunMainMenu();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<EmployeeData>();
                    services.AddSingleton<IEmployeeFetcher, EmployeeFetcher>();
                    services.AddSingleton<IEmployeeDataHandler, EmployeeDataHandler>();
                    services.AddSingleton<IEmployeeSorter, EmployeeSorter>();
                    services.AddSingleton<IEmployeeManager, EmployeeManager>();
                    services.AddSingleton<IMenuOptions, MenuOptions>();
                    services.AddSingleton<IDisplay, Display>();
                    services.AddSingleton<IInputPrompter, InputPrompter>();
                    services.AddSingleton<IInputValidator, InputValidator>();
                    services.AddSingleton<IMenuHandler, MenuHandler>();
                    services.AddSingleton<IModelExtras, ModelExtras>();
                    services.AddSingleton<IMenuRunner, MenuRunner>();
                });
    }
}