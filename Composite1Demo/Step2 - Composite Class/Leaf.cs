using System;
using Composite1Demo.Step1__Component_Interface;

namespace Composite1Demo.Step2___Composite_Class;

public class Leaf(string name) : Component(name)
{
    public override void Add(Component c)
    {
        Console.WriteLine("Cannot  not add to a leaf");
    }

    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot not remove to a leaf");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}