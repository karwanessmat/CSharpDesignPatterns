using System;
using Bridge3Demo.Abstraction;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.RefinedAbstraction
{
   public class Square(IColor color) : Shape(color)
   {
       public override void SetColor()
        {
            Console.Write("Sequre ");
            Color.Color();
        }
    }
}
