using System;
using Flyweight2Demo.Flyweight_Interface;
using Flyweight2Demo.FlyweightFactory;

namespace Flyweight2Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var sof = new ShapeObjectFactory();
            var shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();


            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            Console.WriteLine("_______");

            var numOfObjects = sof.TotalObjectsCreated;
            Console.WriteLine($"total no of objects created {numOfObjects}");

            Console.ReadLine();
        }
    }
}
