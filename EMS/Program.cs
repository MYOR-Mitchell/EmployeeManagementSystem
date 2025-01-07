using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.EmployeeManagementSystem.EMS.Client.Components;
using Project.EmployeeManagementSystem.EMS.Client.Components.Interfaces;
using Project.EmployeeManagementSystem.EMS.Client.UI;
using Project.EmployeeManagementSystem.EMS.Client.UI.Interfaces;
using Project.EmployeeManagementSystem.EMS.Client.View;
using Project.EmployeeManagementSystem.EMS.Client.View.Interfaces;
using Project.EmployeeManagementSystem.EMS.Core.BusinessServices;
using Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces;
using Project.EmployeeManagementSystem.EMS.Data.Context;
using Project.EmployeeManagementSystem.EMS.Data.Repository;
using Project.EmployeeManagementSystem.EMS.Data.Repository.Interfaces;

namespace Project.EmployeeManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Build the host
            using var host = CreateHostBuilder(args).Build();

            // Run the application
            var menuRunner = host.Services.GetRequiredService<IMenuRunner>();
            menuRunner.RunMainMenu();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    // Register data context
                    services.AddSingleton<EmployeeData>();

                    // Register repository classes
                    services.AddSingleton<IEmployeeFetcher, EmployeeFetcher>();
                    services.AddSingleton<IEmployeeManager, EmployeeManager>();
                    services.AddSingleton<IEmployeeSorter, EmployeeSorter>();
                    services.AddSingleton<EmployeeSorter>();

                    // Register core business services
                    services.AddSingleton<IMenuOptions, MenuOptions>();
                    services.AddSingleton<IDisplay, Display>();
                    services.AddSingleton<IGetValidation, GetValidation>();
                    services.AddSingleton<IInputValidation, InputValidation>();
                    services.AddSingleton<IMenuSelectionHandler, MenuSelectionHandler>();
                    services.AddSingleton<IModelExtras, ModelExtras>();
                    services.AddSingleton<ModelExtras>();


                    // Register the MenuRunner
                    services.AddSingleton<IMenuRunner, MenuRunner>();
                });
    }
}
