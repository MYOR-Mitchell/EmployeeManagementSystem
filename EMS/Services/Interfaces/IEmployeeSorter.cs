using EMS.Models;

namespace EMS.Services.Interfaces
{
    public interface IEmployeeSorter
    {
        List<Employee> SortAlphabetical();
        List<Employee> SortSeniority();
        List<Employee> SortRandom();
    }
}
