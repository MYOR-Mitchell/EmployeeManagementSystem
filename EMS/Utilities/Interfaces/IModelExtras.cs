using EMS.Models;

namespace EMS.Utilities.Interfaces
{
    public interface IModelExtras
    {
        string FormatShortHireDate(Employee employee);
        TimeSpan CalculateTimeEmployed(Employee employee);
        int GetSeniorityPosition(Employee employee);
    }
}
