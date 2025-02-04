using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IEmployeeDataHandler
    {
        void AddEmployee(Employee employee);
        void EditEmployee(Employee employee);
        void DeleteEmployee(int id);
        IReadOnlyList<Employee> GetAllEmployees();
    }
}
