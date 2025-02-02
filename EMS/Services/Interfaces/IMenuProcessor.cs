using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IMenuProcessor
    {
        void HandleEmployeeManageSelection(int selection);
        List<Employee> HandleCreateListSelection(int selection);
    }
}
