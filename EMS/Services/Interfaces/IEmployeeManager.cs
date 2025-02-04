using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IEmployeeManager
    {
        void AddEmployee(Employee employee);
        void EditEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployees();
        void ShowAllEmployees();
    }
}
