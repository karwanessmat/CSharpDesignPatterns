using System;
using System.Collections.Generic;
using System.Text;
using Composite3Demo.Component;

namespace Composite3Demo.Leaf
{

    /// <summary>
    /// Leaf
    ///  TeamMember class that represents the leaf node in
    /// the composite structure. Here's how this class looks:
    /// </summary>
   public class TeamMember:Employee
    {
        public TeamMember(string name, decimal salary) : base(name, salary)
        {
        }

        public override void Add(Employee e)
        {
        //Operation not permitted since this is a leaf node.
        }

        public override void Remove(Employee e)
        {
            //Operation not permitted since this is a leaf node.

        }

        public override string GetData(int intend)
        {
            return $"{new string('-', intend)} Name: {Name} Salary: {Salary}\n";
        }
    }
}
