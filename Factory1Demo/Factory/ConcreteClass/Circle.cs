using System;
using System.Collections.Generic;
using System.Text;

namespace Factory1Demo.Factory.ConcreteClass
{
   public class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape of Circle");
        }
    }
}
