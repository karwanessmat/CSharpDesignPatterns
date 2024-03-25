using System;
using System.Collections.Generic;
using System.Text;

namespace Composite3Demo.Component
{

    /// <summary>
    /// Component -- This is represented by either an abstract
    /// class or an interface and serves as the base type
    /// for all objects in the hierarchy
    /// </summary>
  public abstract class Employee
    {
        protected string Name;
        protected decimal Salary;

        protected Employee(string name,decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public abstract void Add(Employee e);
        public abstract void Remove(Employee e);
        public abstract string GetData(int intend);
    }

}
