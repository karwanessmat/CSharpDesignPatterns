using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.RefinedAbstraction
{
    internal class Circle(IColor color) : Shape(color)
    {
        public override void SetColor()
        {
            Console.Write("Circle ");
            Color.Color();

        }
    }
}
