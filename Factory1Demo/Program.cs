using System;
using Factory1Demo.Factory;

namespace Factory1Demo
{
    internal class Program
    {
        private static void Main()
        {

            var shapeFactory = new ShapeFactory();
            var rectangle = shapeFactory.GetShape("rectangle");
            rectangle.Draw();
            Console.WriteLine();
            var circle = shapeFactory.GetShape("circle");
            circle.Draw();
            Console.WriteLine();
            var square = shapeFactory.GetShape("square");
            square.Draw();
        }
    }
}
