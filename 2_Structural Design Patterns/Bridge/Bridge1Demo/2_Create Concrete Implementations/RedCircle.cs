using System;
using Bridge1Demo._1_Define_Implementor_Interface;

namespace Bridge1Demo._2_Create_Concrete_Implementations
{
   public class RedCircle:IDraw
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Red Circle with size radius: {radius}, x: {x}, y: {y}");
        }
    }
}
