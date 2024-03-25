using System;

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
