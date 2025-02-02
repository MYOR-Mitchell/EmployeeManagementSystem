using EMS.Models;

namespace EMS.UI.Interfaces
{
    public interface IDisplay
    {
        void DisplayList<T>(List<T> menu, string prompt = "Select an option: ");
        void DisplayEmployeeBasic(Employee employee);
        void DisplayEmployeeFull(Employee employee);
    }
}
