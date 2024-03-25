using System;
using System.Collections.Generic;
using System.Text;
using Bridge3Demo.Abstraction;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.ConcreteImplementation
{
   public class Sequre:Shape
    {
        public Sequre(IColor color) : base(color)
        {
        }

        public override void SetColor()
        {
            Console.Write("Sequre ");
            Color.Color();
        }
    }
}
