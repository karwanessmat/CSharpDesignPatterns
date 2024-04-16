using System;
using Bridge3Demo._1_Define_Implementor_Interface;
using Bridge3Demo._3_Define_Abstraction;

namespace Bridge3Demo._4_Create_Refined_Abstraction
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
