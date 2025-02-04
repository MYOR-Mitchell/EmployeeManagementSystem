using EMS.Models;
using EMS.Services.Interfaces;
using EMS.UI.Interfaces;

namespace EMS.UI
{
    public class MenuHandler : IMenuHandler
    {
        private readonly IEmployeeSorter _employeeSorter;
        private readonly IEmployeeManager _employeeManager;

        public MenuHandler(IEmployeeSorter employeeSorter, IEmployeeManager employeeManager)
        {
            _employeeSorter = employeeSorter;
            _employeeManager = employeeManager;
        }

        public void HandleEmployeeManageSelection(int selection)
        {
            switch (selection)
            {
                case 1:
                    _employeeManager.AddNewEmployee();
                    break;
                case 2:
                    _employeeManager.EditExistingEmployee();
                    break;
                case 3:
                    _employeeManager.RemoveEmployee();
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
