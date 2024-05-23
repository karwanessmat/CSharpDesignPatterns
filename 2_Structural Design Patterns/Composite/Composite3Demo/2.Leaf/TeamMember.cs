using System;
using Composite3Demo._1._Component;

namespace Composite3Demo._2.Leaf;

/// <summary>
/// Leaf
///  TeamMember class that represents the leaf node in
/// the composite structure. Here's how this class looks:
/// </summary>
public class TeamMember(string name, decimal salary) : Employee(name, salary)
{
    public override void Add(Employee e)
    {
        throw new InvalidOperationException("Cannot add to a leaf");
    }

    public override void Remove(Employee e)
    {
        throw new InvalidOperationException("Cannot remove from a leaf");
    }

    public override void GetData(int indent)
    {
        Console.WriteLine($"{new string('-', indent)} Name: {Name}, Salary: {Salary}");
    }
}