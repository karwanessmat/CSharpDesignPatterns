using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.ConcreteImplementation
{
    class Rectangle:Shape
    {
        public Rectangle(IColor color) : base(color)
        {
        }

        public override void SetColor()
        {
            Console.Write("Rectangle ");
            Color.Color();
        }
    }
}
