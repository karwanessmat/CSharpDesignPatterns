using System;

namespace Factory1Demo.Factory.ConcreteClass
{
   public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape of Rectangle");
        }
    }
}
