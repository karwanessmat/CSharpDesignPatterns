using System;
using System.Collections.Generic;
using System.Linq;
using Template2Demo.AbstractClass;

namespace Template2Demo.ConcreteClass;

public class Products:DataAccessor
{
    private List<string> _products;

    public override void Connect()
    {
        _products = new List<string>();
    }

    public override void Select()
    {
        _products.Add("Car");
        _products.Add("Bike");
        _products.Add("Boat");
        _products.Add("Truck");
        _products.Add("Moped");
        _products.Add("Rollerskate");
        _products.Add("Stroller");
    }

    public override void Process(int top)
    {
        Console.WriteLine("Products ---- ");
            
        foreach (var t in _products)
        {
            Console.WriteLine(t);
        }

        Console.WriteLine();
    }

    public override void Select(string name)
    {
        Console.WriteLine("_____________");

        name = name.ToLower();
        var result = _products.FirstOrDefault(x => x.ToLower() == name);
        Console.WriteLine(result);
    }

    public override void Disconnect()
    {
        _products.Clear();
    }
}