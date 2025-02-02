using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IEmployeeManager
    {
        void AddEmployee(Employee employee);
        void EditEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
