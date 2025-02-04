using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class MenuProcessor : IMenuProcessor
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeSorter _employeeSorter;
        private readonly IEmployeeManager _employeeManager;

        public MenuProcessor(IEmployeeService employeeService, IEmployeeSorter employeeSorter, IEmployeeManager employeeManager)
        {
            _employeeService = employeeService;
            _employeeSorter = employeeSorter;
            _employeeManager = employeeManager;
        }

        public void HandleEmployeeManageSelection(int selection)
        {
            switch (selection)
            {
                case 1:
                    _employeeService.AddNewEmployee();
                    break;
                case 2:
                    _employeeService.EditExistingEmployee();
                    break;
                case 3:
                    _employeeService.RemoveEmployee();
                    break;
                case 4:
                    _employeeManager.ShowAllEmployees();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        public List<Employee> HandleCreateListSelection(int selection)
        {
            return selection switch
            {
                1 => _employeeSorter.SortAlphabetical(),
                2 => _employeeSorter.SortSeniority(),
                3 => _employeeSorter.SortRandom(),
            };
        }
    }
}
