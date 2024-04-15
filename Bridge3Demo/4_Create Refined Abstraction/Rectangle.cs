using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.RefinedAbstraction
{
    class Rectangle(IColor color) : Shape(color)
    {
        public override void SetColor()
        {
            Console.Write("Rectangle ");
            Color.Color();
        }
    }
}
