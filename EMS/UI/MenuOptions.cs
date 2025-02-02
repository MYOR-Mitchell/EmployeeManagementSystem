using EMS.UI.Interfaces;

namespace EMS.UI
{
    public class MenuOptions : IMenuOptions
    {
        public List<string> MainMenu { get; } = new List<string>()
        {
            "Manage Employee Information",
            "Create Employee List"
        };

        public List<string> EmployeeManageMenu { get; } = new List<string>()
        {
            "Add Employee",
            "Edit Employee",
            "Delete Employee",
            "View Employee"
        };

        public List<string> CreateListMenu { get; } = new List<string>()
        {
            "Alphabetically",
            "Seniority",
            "Random"
        };
    }
}
