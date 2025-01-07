using Project.EmployeeManagementSystem.EMS.Core.Model;
using Project.EmployeeManagementSystem.EMS.Data.Context;
using Project.EmployeeManagementSystem.EMS.Data.Repository.Interfaces;

namespace Project.EmployeeManagementSystem.EMS.Data.Repository
{
    public class EmployeeSorter : IEmployeeSorter
    {
        private readonly EmployeeData _employeeData;

        public EmployeeSorter(EmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        public List<Employee> SortAlphabetical()
        {
            List<Employee> sortedEmployees = _employeeData.Employees.OrderBy(e => e.LastName).ThenBy(e => e.FirstName).ToList();
            return sortedEmployees;
        }

        public List<Employee> SortSeniority()
        {
            List<Employee> sortedEmployees = _employeeData.Employees.OrderBy(e => e.HireDate).ThenBy(e => e.LastName).ThenBy(e => e.FirstName).ToList();
            return sortedEmployees;
        }

        public List<Employee> SortRandom()
        {
            List<Employee> sortedEmployees = _employeeData.Employees.OrderBy(e => Guid.NewGuid()).ToList();
            return sortedEmployees;
        }
    }
}
