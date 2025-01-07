using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Data.Repository.Interfaces
{
    public interface IEmployeeManager
    {
        void AddEmployee(Employee employee);
        void EditEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
