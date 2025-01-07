using Project.EmployeeManagementSystem.EMS.Client.UI.Interfaces;
using Project.EmployeeManagementSystem.EMS.Client.View.Interfaces;
using Project.EmployeeManagementSystem.EMS.Client.Components.Interfaces;
using Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces;


namespace Project.EmployeeManagementSystem.EMS.Client.UI
{
    public class MenuRunner : IMenuRunner
    {
        private readonly IDisplay _display;
        private readonly IMenuOptions _menuOptions;
        private readonly IGetValidation _getValidation;
        private readonly IMenuSelectionHandler _menuSelectionHandler;

        public MenuRunner(IDisplay display, IMenuOptions menuOptions, IGetValidation getValidation, IMenuSelectionHandler menuSelectionHandler)
        {
            _display = display;
            _menuOptions = menuOptions;
            _getValidation = getValidation;
            _menuSelectionHandler = menuSelectionHandler;
        }

        public void RunMainMenu() 
        {
            _display.DisplayList(_menuOptions.MainMenu, "Please select from the following options: 'Type 1 to choose Manage Employee Information'");
            var validSelection = _getValidation.GetValidSelection(_menuOptions.MainMenu.Count);

            if (validSelection == 1)
            {
                RunEmployeeManageMenu();
            }
            else if (validSelection == 2)
            {
                RunCreateListMenu();
            }
        }

        public void RunEmployeeManageMenu() 
        {
            _display.DisplayList(_menuOptions.EmployeeManageMenu, "Please select from the following options: 'Type 1 to choose Add Employee'");
            var validSelection = _getValidation.GetValidSelection(_menuOptions.EmployeeManageMenu.Count);
            _menuSelectionHandler.HandleEmployeeManageSelection(validSelection);
        }

        public void RunCreateListMenu() 
        {
            _display.DisplayList(_menuOptions.CreateListMenu, "How would you like the list sorted?");
            var validSelection = _getValidation.GetValidSelection(_menuOptions.CreateListMenu.Count);
            var sortedList = _menuSelectionHandler.HandleCreateListSelection(validSelection);
            _display.DisplayList(sortedList);
        }
    }
}
