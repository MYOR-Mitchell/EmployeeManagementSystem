using EMS.Models;
using EMS.UI.Interfaces;
using EMS.Utilities.Interfaces;

namespace EMS.UI
{
    public class Display : IDisplay
    {
        private readonly IModelExtras _modelExtras;

        public Display(IModelExtras modelExtras)
        {
            _modelExtras = modelExtras;
        }

        public void DisplayList<T>(List<T> list, string prompt = "")
        {
            Console.WriteLine(prompt);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.) {list[i]}");
            }
        }

        public void DisplayEmployeeBasic(Employee employee)
        {
            string hireDateShort = _modelExtras.FormatShortHireDate(employee);

            Console.WriteLine($"Employee ID: {employee.Id}");
            Console.WriteLine($"First name: {employee.FirstName}");
            Console.WriteLine($"Last name: {employee.LastName}");
            Console.WriteLine($"Hire date: {hireDateShort}");
        }

        public void DisplayEmployeeFull(Employee employee)
        {
            string shortHireDate = _modelExtras.FormatShortHireDate(employee);
            TimeSpan timeEmployed = _modelExtras.CalculateTimeEmployed(employee);
            int seniorityPosition = _modelExtras.GetSeniorityPosition(employee);

            Console.WriteLine($"Employee ID: {employee.Id}");
            Console.WriteLine($"First name: {employee.FirstName}");
            Console.WriteLine($"Last name: {employee.LastName}");
            Console.WriteLine($"Hire date: {shortHireDate}");
            Console.WriteLine($"Time Employed: {timeEmployed}");
            Console.WriteLine($"Seniority Position: {seniorityPosition}");
        }
    }
}
