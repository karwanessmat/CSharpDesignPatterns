using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.ConcreteImplementation;
using Bridge3Demo.RefinedAbstraction;

namespace Bridge3Demo
{
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
}
