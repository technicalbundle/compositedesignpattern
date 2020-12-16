using System;

namespace CompositeDesignPattern
{
    /// <summary>
    /// This is an Employee class and represent the Leaf or the Primitive type in the tree structure
    /// that cannot have children. This class implements the abstract WorkHourComponent class
    /// and overrides the GetWorkingHour() method to return the working hour recorded for the employee
    /// </summary>
    public class Employee : WorkHourComponent
    {
        public int Id { get; set; }
        public int WorkHour { get; set; } 
        public override int GetWorkingHour()
        {
            Console.WriteLine($"Employee Id# {Id} - {Name} recorded {WorkHour} work hours");
            return WorkHour;
        } 
    }
}
