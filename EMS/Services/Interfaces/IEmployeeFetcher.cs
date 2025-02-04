using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IEmployeeFetcher
    {
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string firstName, string lastName);
    }
}
