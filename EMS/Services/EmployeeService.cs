using EMS.Models;
using EMS.Validation.Interfaces;
using EMS.Services.Interfaces;

namespace EMS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeManager _employeeManager;
        private readonly IGetValidation _getValidation;

        public EmployeeService(IEmployeeManager employeeManager, IGetValidation getValidation)
        {
            _employeeManager = employeeManager;
            _getValidation = getValidation;
        }

        public void AddNewEmployee()
        {
            string firstName = _getValidation.GetValidName("Enter first name: ");
            string lastName = _getValidation.GetValidName("Enter last name: ");
            DateTime hireDate = _getValidation.GetValidHireDate("Enter hire date (yyyy-mm-dd): ");
            int id = GenerateUniqueId();

            var newEmployee = new Employee(id, firstName, lastName, hireDate);
            _employeeManager.AddEmployee(newEmployee);
            Console.WriteLine("Employee added successfully.");
        }

        public void EditExistingEmployee()
        {
            int id = _getValidation.GetValidId("Enter the employee ID to edit: ");
            var employee = _employeeManager.GetAllEmployees().FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                Console.WriteLine($"Employee with ID {id} not found.");
                return;
            }

            string newFirstName = _getValidation.GetValidName("Enter new first name: ");
            string newLastName = _getValidation.GetValidName("Enter new last name: ");
            DateTime newHireDate = _getValidation.GetValidHireDate("Enter new hire date (yyyy-mm-dd): ");

            employee.FirstName = newFirstName;
            employee.LastName = newLastName;
            employee.HireDate = newHireDate;

            _employeeManager.EditEmployee(employee);
            Console.WriteLine($"Employee with ID {id} updated successfully.");
        }

        public void RemoveEmployee()
        {
            int id = _getValidation.GetValidId("Enter the employee ID to delete: ");
            var employeeExists = _employeeManager.GetAllEmployees().Any(e => e.Id == id);

            if (!employeeExists)
            {
                Console.WriteLine($"Employee with ID {id} not found.");
                return;
            }

            _employeeManager.DeleteEmployee(id);
            Console.WriteLine($"Employee with ID {id} has been deleted.");
        }

        private int GenerateUniqueId()
        {
            int newId;
            Random random = new Random();
            do
            {
                newId = random.Next(100000, 999999);
            } while (_employeeManager.GetAllEmployees().Any(e => e.Id == newId));
            return newId;
        }
    }
}