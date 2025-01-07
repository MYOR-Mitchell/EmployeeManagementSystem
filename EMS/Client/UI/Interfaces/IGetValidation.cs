namespace Project.EmployeeManagementSystem.EMS.Client.UI.Interfaces
{
    public interface IGetValidation
    {
        int GetValidSelection(int maxRange);
        string GetValidName(string prompt = "");
        DateTime GetValidHireDate(string prompt = "");
    }
}
