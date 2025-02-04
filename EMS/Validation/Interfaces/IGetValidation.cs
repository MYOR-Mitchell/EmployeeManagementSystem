namespace EMS.Validation.Interfaces
{
    public interface IGetValidation
    {
        int GetValidSelection(int maxRange);
        string GetValidName(string prompt = "");
        DateTime GetValidHireDate(string prompt = "");
        int GetValidId(string prompt);

    }
}
