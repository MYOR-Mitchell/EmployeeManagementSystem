using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces
{
    public interface IModelExtras
    {
        string FormatShortHireDate(Employee employee);
        TimeSpan CalculateTimeEmployed(Employee employee);
        int GetSeniorityPosition(Employee employee);
    }
}
