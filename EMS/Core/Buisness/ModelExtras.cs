using Project.EmployeeManagementSystem.EMS.Core.BusinessServices.Interfaces;
using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Core.BusinessServices
{
    public class ModelExtras : IModelExtras
    {
        public string FormatShortHireDate(Employee employee)
        {
            return employee.HireDate.ToShortDateString();
        }

        public TimeSpan CalculateTimeEmployed(Employee employee)
        {
            return DateTime.Now - employee.HireDate;
        }

        public int GetSeniorityPosition(Employee employee)
        {
            // Placeholder.  Don't forget to do this.
            return 0;
        }
    }
}
