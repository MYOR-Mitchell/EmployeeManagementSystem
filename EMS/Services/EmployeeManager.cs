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
            //Don't forget to do this!
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeData.Employees.Remove(employee);
        }


    }
}
