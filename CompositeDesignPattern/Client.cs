using System;

namespace CompositeDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Organization organization = new Organization { Name = "Great Organization" };

            Organization itDepartment = new Organization { Name = "IT Department" };
            itDepartment.Add(new Employee { Id = 1001, Name = "John Doe", WorkHour = 8 });
            itDepartment.Add(new Employee { Id = 1002, Name = "Michelle Ritzwick", WorkHour = 6 });
            itDepartment.Add(new Employee { Id = 1005, Name = "Sabir Bhatia", WorkHour = 8 });

            Organization financeDepartment = new Organization { Name = "Finance Department" };
            financeDepartment.Add(new Employee { Id = 1003, Name = "Sunny Wenk", WorkHour = 7 });
            financeDepartment.Add(new Employee { Id = 1004, Name = "Stuart Board", WorkHour = 5 });

            organization.Add(itDepartment);
            organization.Add(financeDepartment);

            organization.GetWorkingHour();        
        }
    }
}
