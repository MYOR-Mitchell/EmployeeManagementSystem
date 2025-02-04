using EMS.Services;
using EMS.Data;
using EMS.Models;

namespace EMS.Tests.Services
{
    public class EmployeeFetcherTests
    {
        private readonly EmployeeDataHandler _dataHandler;
        private readonly EmployeeFetcher _fetcher;

        public EmployeeFetcherTests()
        {
            _dataHandler = new EmployeeDataHandler(new EmployeeData());
            _fetcher = new EmployeeFetcher(_dataHandler);

            _dataHandler.AddEmployee(new Employee(123456, "John", "Doe", new DateTime(1990, 5, 15)));
        }

        [Theory]
        [InlineData("John", "Doe")]
        [InlineData("john", "doe")]
        [InlineData("JOHN", "DOE")]
        public void GetEmployeeByName_ShouldReturnCorrectEmployee(string firstName, string lastName)
        {
            var expectedEmployee = _dataHandler.GetAllEmployees().FirstOrDefault(e =>
                e.FirstName.Equals("John", StringComparison.OrdinalIgnoreCase) &&
                e.LastName.Equals("Doe", StringComparison.OrdinalIgnoreCase));

            Assert.NotNull(expectedEmployee);

            var result = _fetcher.GetEmployeeByName(firstName, lastName);

            Assert.NotNull(result);
            Assert.Equal(expectedEmployee.Id, result.Id);
        }

        [Fact]
        public void GetEmployeeByName_ShouldThrowException_WhenEmployeeDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                _fetcher.GetEmployeeByName("Fake", "Person");
            });
        }
    }
}