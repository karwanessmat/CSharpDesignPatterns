using System;
using Factory1Demo.Step1_Product_Interface;
using Factory1Demo.step4_Concrete_Creator;

namespace Factory1Demo;

internal class Program
{
    private static void Main()
    {

        var shapeFactory = new ShapeFactory();
        IShape rectangle = shapeFactory.GetShape("rectangle");
        rectangle.Draw();
        Console.WriteLine();
        IShape circle = shapeFactory.GetShape("circle");
        circle.Draw();
        Console.WriteLine();
        IShape square = shapeFactory.GetShape("square");
        square.Draw();
    }
}