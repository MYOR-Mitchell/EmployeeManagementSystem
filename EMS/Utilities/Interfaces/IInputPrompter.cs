namespace EMS.Utilities.Interfaces
{
    public interface IInputPrompter
    {
        int GetValidSelection(int maxRange);
        string GetValidName(string prompt = "");
        DateTime GetValidHireDate(string prompt = "");
        int GetValidId(string prompt);

    }
}
