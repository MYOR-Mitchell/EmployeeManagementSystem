
using EMS.Models;
using EMS.Services.Interfaces;
using EMS.Services;
using Moq;

namespace EMS.Tests.Services
{
    public class EmployeeSorterTests
    {
        [Fact]
        public void SortAlphabetical_ShouldSortEmployeesAlphabetically()
        {

            var employees = new List<Employee>
            {
                new Employee(1, "Zack", "Anderson", new DateTime(2018, 5, 10)),
                new Employee(2, "Terry", "Smith", new DateTime(2020, 3, 15)),
                new Employee(4, "Alice", "Brown", new DateTime(2010, 7, 22)),
                new Employee(5, "John", "Little", new DateTime(2020, 3, 15)),
                new Employee(6, "Alice", "Brown", new DateTime(2015, 7, 22)),
                new Employee(7, "Zack", "Brown", new DateTime(2000, 3, 12))
            };

            var mockManager = new Mock<IEmployeeManager>();
            mockManager.Setup(f => f.GetAllEmployees()).Returns(employees);

            var sorter = new EmployeeSorter(mockManager.Object);
            var sortedList = sorter.SortAlphabetical();

            var expectedOrder = new List<string>
            {
                "Zack Anderson",
                "Alice Brown",
                "Alice Brown",
                "Zack Brown",
                "John Little",
                "Terry Smith"
            };

            var actualOrder = sortedList.Select(e => $"{e.FirstName} {e.LastName}").ToList();

            Assert.Equal(expectedOrder, actualOrder);
        }
    }
}
