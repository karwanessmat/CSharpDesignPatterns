using System;

namespace Proxy3Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Create math proxy
            IMath proxy = new MathProxy();

            // Do the math
            Console.WriteLine("Proxy: 4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("Proxy: 4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("Proxy: 4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("Proxy: 4 / 2 = " + proxy.Div(4, 2));

            Console.WriteLine();

            // Create math proxy
            IMath math = new Math();

            // Do the math
            Console.WriteLine("math: 4 + 2 = " + math.Add(4, 2));
            Console.WriteLine("math: 4 - 2 = " + math.Sub(4, 2));
            Console.WriteLine("math: 4 * 2 = " + math.Mul(4, 2));
            Console.WriteLine("math: 4 / 2 = " + math.Div(4, 2));


            // Wait for user
            Console.ReadKey();
        }
    }
}
