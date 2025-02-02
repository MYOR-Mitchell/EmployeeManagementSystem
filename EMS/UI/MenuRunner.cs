using EMS.UI.Interfaces;
using EMS.Services.Interfaces;
using EMS.Validation.Interfaces;


namespace EMS.UI
{
    public class MenuRunner : IMenuRunner
    {
        private readonly IDisplay _display;
        private readonly IMenuOptions _menuOptions;
        private readonly IGetValidation _getValidation;
        private readonly IMenuProcessor _menuSelectionHandler;

        public MenuRunner(IDisplay display, IMenuOptions menuOptions, IGetValidation getValidation, IMenuProcessor menuSelectionHandler)
        {
            _display = display;
            _menuOptions = menuOptions;
            _getValidation = getValidation;
            _menuSelectionHandler = menuSelectionHandler;
        }

        public void RunMainMenu()
        {
            _display.DisplayList(_menuOptions.MainMenu, "Please select from the following options: \n");
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
            _display.DisplayList(_menuOptions.EmployeeManageMenu, "Please select from the following options: ");
            var validSelection = _getValidation.GetValidSelection(_menuOptions.EmployeeManageMenu.Count);
            _menuSelectionHandler.HandleEmployeeManageSelection(validSelection);
        }

        public void RunCreateListMenu()
        {
            _display.DisplayList(_menuOptions.CreateListMenu, "How would you like the list sorted?");
            var validSelection = _getValidation.GetValidSelection(_menuOptions.CreateListMenu.Count);
            var sortedList = _menuSelectionHandler.HandleCreateListSelection(validSelection);

            if (!sortedList.Any())  
            {
                Console.WriteLine("No employees found for sorting.");
                return;
            }

            _display.DisplayList(sortedList);
        }
    }
}
