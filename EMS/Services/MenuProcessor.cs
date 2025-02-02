using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class MenuProcessor : IMenuProcessor
    {
        private readonly IEmployeeSorter _employeeSorter;

        public MenuProcessor(IEmployeeSorter employeeSorter)
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
