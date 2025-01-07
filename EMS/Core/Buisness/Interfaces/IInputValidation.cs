

namespace Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces
{
    public interface IInputValidation
    {
        bool ValidateSelection(string input, int maxRange, out int validSelection);
        bool ValidateName(string input);
        bool ParseInt(string selection, out int validSelection);
        bool ParseDateTime(string hireDate, out DateTime validHireDate, string format = "yyyy/MM/dd");
        bool CheckIntRange(int checkInt, int maxRange);
    }
}
