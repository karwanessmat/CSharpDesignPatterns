namespace Composite3Demo._1._Component;

/// <summary>
/// Component -- This is represented by either an abstract
/// class or an interface and serves as the base type
/// for all objects in the hierarchy
/// </summary>
public abstract class Employee(string name, decimal salary)
{
    protected string Name = name;
    protected decimal Salary = salary;

    public abstract void Add(Employee e);
    public abstract void Remove(Employee e);
    public abstract void GetData(int indent);
}