using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.ConcreteImplementation
{
    internal class Circle:Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override void SetColor()
        {
            Console.Write("Circle ");
            Color.Color();

        }
    }
}
