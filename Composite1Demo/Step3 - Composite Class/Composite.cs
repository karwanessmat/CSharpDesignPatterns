using System;
using System.Collections.Generic;
using Composite1Demo.Step1__Component_Interface;

namespace Composite1Demo.Step3___Leaf_Class;

/// <summary>
/// The 'Composite' class
/// </summary>
public class Composite(string name) : Component(name)
{
    private readonly List<Component> _children = new();

    public override void Add(Component c)
    {
        _children.Add(c);
    }

    public override void Remove(Component c)
    {
        _children.Remove(c);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}
