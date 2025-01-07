using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Data.Repository.Interfaces
{
    public interface IEmployeeFetcher
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string firstName, string lastName);
    }
}
