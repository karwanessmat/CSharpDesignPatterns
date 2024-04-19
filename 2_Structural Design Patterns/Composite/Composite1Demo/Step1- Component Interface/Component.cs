namespace Composite1Demo.Step1__Component_Interface;

/// <summary>
/// The 'Component' abstract class
/// </summary>

public abstract class Component(string name)
{
    protected string Name = name;


    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth);
}