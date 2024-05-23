using System;
using System.Collections.Generic;
using Composite3Demo._1._Component;

namespace Composite3Demo._3.Composite;

/// <summary>
/// Composite: it represents the "Composite" type in our design,
/// extends the Employee class, and provides the definition
/// for the abstract methods.
/// </summary>
public class TeamLead(string name, decimal salary) : Employee(name, salary)
{
    private readonly List<Employee> _employees = new();

    public override void Add(Employee e)
    {
        _employees.Add(e);
    }

    public override void Remove(Employee e)
    {
        _employees.Remove(e);
    }

    public override void GetData(int indent)
    {
        Console.WriteLine($"{new string('+', indent)} Team Leader: {Name}, Salary: {Salary}");
        foreach (var employee in _employees)
        {
            employee.GetData(indent + 2);
        }
    }
}