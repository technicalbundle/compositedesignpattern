using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    /// <summary>
    /// This is the composite class and represents the complex (composite) objects that can have Employee (leaf) 
    /// and other composite as its children
    /// </summary>
    public class Organization : WorkHourComponent
    {
        protected List<WorkHourComponent> branches = new List<WorkHourComponent>();

        public override void Add(WorkHourComponent component)
        {
            branches.Add(component);
        }

        public override void Remove(WorkHourComponent component)
        {
            branches.Remove(component);
        }

        /// <summary>
        /// This is the common functionality
        /// </summary>
        /// <returns></returns>
        public override int GetWorkingHour()
        {
            var branchWorkingHours = 0;

            foreach (var branch in branches)
            {    
                branchWorkingHours += branch.GetWorkingHour();
            }

            Console.WriteLine($"{Name} recorded a total of [{branchWorkingHours}] Hours");
            Console.WriteLine();
            return branchWorkingHours;
        }
    }
}
