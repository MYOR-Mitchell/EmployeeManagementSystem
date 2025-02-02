using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class EmployeeSorter : IEmployeeSorter
    {
        private readonly IEmployeeFetcher _employeeFetcher;

        public EmployeeSorter(IEmployeeFetcher employeeFetcher)
        {
            _employeeFetcher = employeeFetcher;
        }

        public List<Employee> SortAlphabetical()
        {
            return _employeeFetcher.GetAllEmployees()
                .OrderBy(e => e.LastName)
                .ThenBy(e => e.FirstName)
                .ToList();
        }

        public List<Employee> SortSeniority()
        {
            return _employeeFetcher.GetAllEmployees()
                .OrderBy(e => e.HireDate)
                .ThenBy(e => e.LastName)
                .ThenBy(e => e.FirstName)
                .ToList();
        }

        public List<Employee> SortRandom()
        {
            return _employeeFetcher.GetAllEmployees()
                .OrderBy(e => Guid.NewGuid())
                .ToList();
        }
    }
}