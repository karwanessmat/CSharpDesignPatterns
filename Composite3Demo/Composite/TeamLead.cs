using System.Collections.Generic;
using System.Text;
using Composite3Demo.Component;

namespace Composite3Demo.Composite
{

    /// <summary>
    /// Composite: it represents the "Composite" type in our design,
    /// extends the Employee class, and provides the definition
    /// for the abstract methods.
    /// </summary>
    public   class TeamLead:Employee
    {
        readonly List<Employee> _employees =new List<Employee>();
        public TeamLead(string name, decimal salary) : base(name, salary)
        {
        }

        public override void Add(Employee e)
        {
            _employees.Add(e);
        }

        public override void Remove(Employee e)
        {
            _employees.Remove(e);
        }

        public override string GetData(int intend)
        {
            var sb =new StringBuilder();
            sb.Append($"{new string('-',intend)}+Team Leader: {Name}, Salary {Salary}\n");
            foreach (var employee in _employees)
            {
                sb.Append($"{employee.GetData(intend+1)}");
            }

            return sb.ToString();
        }
    }
}
