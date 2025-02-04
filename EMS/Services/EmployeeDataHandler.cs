using EMS.Data;
using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class EmployeeDataHandler : IEmployeeDataHandler
    {
        private readonly EmployeeData _employeeData;

        public EmployeeDataHandler(EmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeData.Employees.Add(employee);
        }

        public void EditEmployee(Employee employee)
        {
            var existingEmployee = _employeeData.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.HireDate = employee.HireDate;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employeeData.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeData.Employees.Remove(employee);
            }
        }

        public IReadOnlyList<Employee> GetAllEmployees()
        {
            return _employeeData.Employees.AsReadOnly();
        }
    }
}