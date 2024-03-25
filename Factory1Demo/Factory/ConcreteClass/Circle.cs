using System;

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
