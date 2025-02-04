using EMS.Models;

namespace EMS.UI.Interfaces
{
    public interface IMenuHandler
    {
        void HandleEmployeeManageSelection(int selection);
        List<Employee> HandleCreateListSelection(int selection);
    }
}
