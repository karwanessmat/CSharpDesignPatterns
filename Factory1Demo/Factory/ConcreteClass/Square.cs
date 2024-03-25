using System;
using System.Collections.Generic;
using System.Text;

namespace Factory1Demo.Factory.ConcreteClass
{
   public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape of Square");
        }
    }
}
