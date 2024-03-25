using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.ConcreteImplementation;
using Bridge3Demo.Refined_Abstraction;
using Bridge3Demo.RefinedAbstraction;

namespace Bridge3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(new RedColor());
            Shape sequre = new Sequre(new GreenColor());

            


            circle.SetColor();
            sequre.SetColor();


            Console.ReadKey();

        }
    }
}
