using Project.EmployeeManagementSystem.EMS.Core.Model;
using Project.EmployeeManagementSystem.EMS.Data.Context;
using Project.EmployeeManagementSystem.EMS.Data.Repository.Interfaces;

namespace Project.EmployeeManagementSystem.EMS.Data.Repository
{
    public class EmployeeFetcher : IEmployeeFetcher
    {
        private readonly EmployeeData _employeeData;

        public EmployeeFetcher(EmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeData.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeData.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee GetEmployeeByName(string firstName, string lastName)
        {
            return _employeeData.Employees.FirstOrDefault(e => e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && e.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
