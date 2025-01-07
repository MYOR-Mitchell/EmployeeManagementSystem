using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Client.View.Interfaces
{
    public interface IDisplay
    {
        void DisplayList<T>(List<T> menu, string prompt = "Select an option: ");
        public void DisplayEmployeeBasic(Employee employee);
        void DisplayEmployeeFull(Employee employee);
    }
}
