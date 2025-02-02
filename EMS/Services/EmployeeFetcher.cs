using EMS.Data;
using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
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
            var employee = _employeeData.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                throw new InvalidOperationException($"Employee ID {id} not found.");
            }

            return employee;
        }

        public Employee GetEmployeeByName(string firstName, string lastName)
        {
            var employee = _employeeData.Employees.FirstOrDefault(e =>
                e.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                e.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (employee == null)
            {
                throw new InvalidOperationException($"Employee {firstName} {lastName} not found.");
            }

            return employee;
        }
    }
}
