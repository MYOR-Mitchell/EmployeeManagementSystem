using EMS.Data;
using EMS.Models;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly EmployeeData _employeeData;

        public EmployeeManager(EmployeeData employeeData)
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

        public List<Employee> GetAllEmployees()
        {
            return _employeeData.Employees.ToList();
        }

        public void ShowAllEmployees()
        {
            var employees = GetAllEmployees();

            if (!employees.Any())
            {
                Console.WriteLine("No employees found.");
                return;
            }

            Console.WriteLine("\nEmployee List:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee); 
            }
        }

    }
}

