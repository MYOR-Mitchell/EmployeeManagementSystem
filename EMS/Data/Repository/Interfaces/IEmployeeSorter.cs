using Project.EmployeeManagementSystem.EMS.Core.Model;

namespace Project.EmployeeManagementSystem.EMS.Data.Repository.Interfaces
{
    public interface IEmployeeSorter
    {
        List<Employee> SortAlphabetical();
        List<Employee> SortSeniority();
        List<Employee> SortRandom();
    }
}
