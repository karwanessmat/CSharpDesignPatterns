using System;
using System.Collections.Generic;
using System.Linq;
using Template2Demo.AbstractClass;

namespace Template2Demo.ConcreteClass;

/// <summary>
/// A 'ConcreteClass' class
/// </summary>
internal class Categories : DataAccessor
{

    private List<string> _categories;
    public override void Connect()
    {
        _categories = new List<string>();
    }

    public override void Select()
    {
        _categories.Add("Red");
        _categories.Add("Green");
        _categories.Add("Blue");
        _categories.Add("Yellow");
        _categories.Add("Purple");
        _categories.Add("White");
        _categories.Add("Black");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Categories _____");
        for (var i = 0; i < top; i++)
        {
            Console.WriteLine(_categories[i]);
        }

        Console.WriteLine();
    }

    public override void Select(string name)
    {
        name = name.ToLower();
        Console.WriteLine(_categories.FirstOrDefault(x => x.ToLower() == name));
    }

    public override void Disconnect()
    {
        _categories.Clear();
    }
}