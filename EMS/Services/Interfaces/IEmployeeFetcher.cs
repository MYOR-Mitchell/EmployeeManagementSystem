using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IEmployeeFetcher
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string firstName, string lastName);
    }
}
