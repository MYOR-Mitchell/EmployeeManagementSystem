using EMS.Models;

namespace EMS.Data
{
    public class EmployeeData
    {
        public List<Employee> Employees => _employees;


        private List<Employee> _employees = new List<Employee> 
        {
            new Employee(568013, "Ella", "Adams", new DateTime(2003, 8, 11)),
            new Employee(679124, "Avery", "Baker", new DateTime(2002, 4, 22)),
            new Employee(990123, "Henry", "Martinez", new DateTime(2020, 1, 10)),
            new Employee(789012, "Michael", "Davis", new DateTime(2015, 11, 5)),
            new Employee(223456, "Daniel", "Taylor", new DateTime(2023, 7, 25)),
            new Employee(579124, "Ava", "Allen", new DateTime(2014, 11, 30)),
            new Employee(680235, "Isabella", "Young", new DateTime(2013, 3, 21)),
            new Employee(791346, "Sophia", "Hernandez", new DateTime(2012, 7, 18)),
            new Employee(802457, "Mia", "King", new DateTime(2011, 5, 25)),
            new Employee(913568, "Charlotte", "Wright", new DateTime(2009, 10, 9)),
            new Employee(124679, "Amelia", "Lopez", new DateTime(2008, 12, 3)),
            new Employee(135790, "Liam", "Clark", new DateTime(2018, 6, 12)),
            new Employee(246801, "Noah", "Lewis", new DateTime(2019, 8, 23)),
            new Employee(235780, "Harper", "Hill", new DateTime(2007, 1, 15)),
            new Employee(112345, "Emily", "Taylor", new DateTime(2022, 5, 20)),
            new Employee(123456, "John", "Doe", new DateTime(1992, 9, 26)),
            new Employee(667890, "William", "Taylor", new DateTime(2005, 7, 25)),
            new Employee(234567, "John", "Doe", new DateTime(1995, 4, 15)),
            new Employee(556789, "Olivia", "Taylor", new DateTime(2000, 5, 20)),
            new Employee(101234, "Evelyn", "Robinson", new DateTime(2021, 3, 15)),
            new Employee(445678, "James", "Taylor", new DateTime(1995, 4, 15)),
            new Employee(346891, "Evelyn", "Scott", new DateTime(2006, 9, 27)),
            new Employee(457902, "Abigail", "Green", new DateTime(2004, 6, 5)),
            new Employee(345678, "Jane", "Smith", new DateTime(2000, 5, 20)),
            new Employee(212345, "Lucas", "Thompson", new DateTime(2022, 5, 20)),
            new Employee(778901, "Ava", "Taylor", new DateTime(2010, 9, 30)),
            new Employee(567890, "Michael", "Johnson", new DateTime(2005, 7, 25)),
            new Employee(889012, "Alexander", "Taylor", new DateTime(2015, 11, 5)),
            new Employee(901234, "Michael", "Moore", new DateTime(2021, 3, 15)),
            new Employee(456789, "Jane", "Smith", new DateTime(2000, 5, 20)),
            new Employee(678901, "Michael", "Brown", new DateTime(2010, 9, 30)),
            new Employee(334567, "Sophia", "Taylor", new DateTime(1992, 9, 26)),
            new Employee(323456, "Amelia", "Garcia", new DateTime(2023, 7, 25)),
            new Employee(434567, "Benjamin", "Harris", new DateTime(1992, 9, 26)),
            new Employee(890123, "Michael", "Wilson", new DateTime(2020, 1, 10)),
            new Employee(545678, "Mia", "Martin", new DateTime(1995, 4, 15)),
            new Employee(656789, "Isabella", "White", new DateTime(2000, 5, 20)),
            new Employee(767890, "Sophia", "Wilson", new DateTime(2005, 7, 25)),
            new Employee(878901, "James", "Moore", new DateTime(2010, 9, 30)),
            new Employee(989012, "Olivia", "Taylor", new DateTime(2015, 11, 5)),
            new Employee(100123, "William", "Anderson", new DateTime(2020, 1, 10)),
            new Employee(111234, "Ava", "Thomas", new DateTime(2021, 3, 15)),
            new Employee(357912, "Emma", "Walker", new DateTime(2017, 4, 14)),
            new Employee(122345, "Alexander", "Jackson", new DateTime(2022, 5, 20)),
            new Employee(468013, "Olivia", "Hall", new DateTime(2016, 2, 19)),
        };
    }
}
