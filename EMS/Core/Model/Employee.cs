
namespace Project.EmployeeManagementSystem.EMS.Core.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id, string firstName, string lastName, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
        }

        // Override ToString to provide a clean display of employee details
        public override string ToString()
        {
            return $"{FirstName} {LastName}, Hired: {HireDate.ToShortDateString()}";
        }
    }
}
