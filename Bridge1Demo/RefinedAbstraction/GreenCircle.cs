using System;
using Bridge1Demo.Implementor;

namespace Bridge1Demo.RefinedAbstraction
{
   public class GreenCircle:IDraw
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Green Circle with size radius: {radius}, x: {x}, y: {y}");
        }
    }
}
