using System;
using Flyweight2Demo._1_Flyweight_Interface;

namespace Flyweight2Demo._2__Concrete_Flyweight;

/// <summary>
/// ConcreteFlyweight class
/// </summary>
internal class Rectangle:IShape
{
    public void Print()
    {
        Console.WriteLine("Printing Rectangle");
    }
}