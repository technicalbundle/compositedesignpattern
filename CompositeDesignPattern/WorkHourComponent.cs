using System;

namespace CompositeDesignPattern
{
    /// <summary>
    /// This is the base Component class that declare the common functionality of GetWorkingHour for both the 
    /// Employee (primitive) and the Organization (composite type) objects. The class also contains the tree child 
    /// management API - ADD and Remove and the same will be ignored for the Employee (leaf) components
    /// </summary>
    public abstract class WorkHourComponent
    {
        public WorkHourComponent()
        {

        }

        public string Name { get; set; } 
        
        public abstract int GetWorkingHour();

        public virtual void Add(WorkHourComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(WorkHourComponent component)
        {
            throw new NotImplementedException();
        }  
    }
}
