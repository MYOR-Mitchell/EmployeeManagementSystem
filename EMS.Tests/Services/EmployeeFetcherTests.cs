using EMS.Services;
using EMS.Data;

namespace EMS.Tests.Services
{
    public class EmployeeFetcherTests
    {
        private readonly EmployeeFetcher _fetcher;
        private readonly EmployeeData _employeeData;

        public EmployeeFetcherTests()
        {
            _employeeData = new EmployeeData();
            _fetcher = new EmployeeFetcher(_employeeData);
        }

        [Theory]
        [InlineData("John", "Doe")]
        [InlineData("john", "doe")]
        [InlineData("JOHN", "DOE")]
        public void GetEmployeeByName_ShouldReturnCorrectEmployee(string firstName, string lastName)
        {
            var expectedEmployee = _employeeData.Employees.First(e => e.FirstName == "John" && e.LastName == "Doe");

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
