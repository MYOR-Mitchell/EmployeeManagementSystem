using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces
{
    public interface IMenuSelectionHandler
    {
        void HandleEmployeeManageSelection(int selection);
        List<Employee> HandleCreateListSelection(int selection);
    }
}
