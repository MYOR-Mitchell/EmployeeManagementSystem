using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class EmployeeSorter : IEmployeeSorter
    {
        private readonly IEmployeeDataHandler _EmployeeManager;

        public EmployeeSorter(IEmployeeDataHandler EmployeeManager)
        {
            _EmployeeManager = EmployeeManager;
        }

        public List<Employee> SortAlphabetical()
        {
            return _EmployeeManager.GetAllEmployees()
                .OrderBy(e => e.LastName)
                .ThenBy(e => e.FirstName)
                .ToList();
        }

        public List<Employee> SortSeniority()
        {
            return _EmployeeManager.GetAllEmployees()
                .OrderBy(e => e.HireDate)
                .ThenBy(e => e.LastName)
                .ThenBy(e => e.FirstName)
                .ToList();
        }

        public List<Employee> SortRandom()
        {
            return _EmployeeManager.GetAllEmployees()
                .OrderBy(e => Guid.NewGuid())
                .ToList();
        }
    }
}