using System;
using Bridge3Demo._2_Create_Concrete_Implementations;
using Bridge3Demo._3_Define_Abstraction;
using Bridge3Demo._4_Create_Refined_Abstraction;

namespace Bridge3Demo;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(new RedColor());
        Shape sequre = new Square(new GreenColor());
        Shape rectangle = new Rectangle(new GreenColor());




        circle.SetColor();
        sequre.SetColor();
        rectangle.SetColor();


        Console.ReadKey();

    }
}