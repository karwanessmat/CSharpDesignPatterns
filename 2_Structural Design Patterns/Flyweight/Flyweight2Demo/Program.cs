using System;
using Flyweight2Demo._1_Flyweight_Interface;
using Flyweight2Demo._3_Flyweight_Factory;

namespace Flyweight2Demo;

class Program
{
    static void Main(string[] args)
    {

        var sof = new ShapeObjectFactory();
        IShape shape = sof.GetShape("Rectangle");
        shape.Print();
        shape = sof.GetShape("Rectangle");
        shape.Print();


        shape = sof.GetShape("Circle");
        shape.Print();
        shape = sof.GetShape("Circle");
        shape.Print();

        Console.WriteLine("_______");

        int numOfObjects = sof.TotalObjectsCreated;
        Console.WriteLine($"total no of objects created {numOfObjects}");

        Console.ReadLine();
    }
}