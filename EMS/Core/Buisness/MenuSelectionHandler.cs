using Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces;
using Project.EmployeeManagementSystem.EMS.Core.Model;
using Project.EmployeeManagementSystem.EMS.Data.Repository;

namespace Project.EmployeeManagementSystem.EMS.Core.BusinessServices
{
    public class MenuSelectionHandler : IMenuSelectionHandler
    {
        private readonly EmployeeSorter _employeeSorter;

        public MenuSelectionHandler(EmployeeSorter employeeSorter)
        {
            _employeeSorter = employeeSorter;
        }

        public void HandleEmployeeManageSelection(int selection)
        {
            Action action = selection switch
            {
                1 => () => Console.WriteLine("AddEmployee"),
                2 => () => Console.WriteLine("EditEmployees"),
                3 => () => Console.WriteLine("DeleteEmployees"), 
                4 => () => Console.WriteLine("ViewEmployees"),
            };

            action();
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
