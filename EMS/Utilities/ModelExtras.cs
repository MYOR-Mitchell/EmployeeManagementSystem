using EMS.Models;
using EMS.Utilities.Interfaces;

namespace EMS.Utilities
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
            return 0;
        }
    }
}
