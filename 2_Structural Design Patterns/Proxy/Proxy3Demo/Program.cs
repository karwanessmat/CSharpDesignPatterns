using System;
using Proxy3Demo._1._Subject_Interface;
using Proxy3Demo._3.Proxy;

namespace Proxy3Demo;

internal class Program
{
    static void Main(string[] args)
    {

        // Create a proxy object
        IMath mathProxy = new MathProxy();

        // Perform operations via the proxy
        Console.WriteLine($"Adding 5 and 2: {mathProxy.Add(5, 2)}");  // Outputs: Adding 5 and 2: 7
        Console.WriteLine($"Subtracting 5 from 2: {mathProxy.Sub(5, 2)}");  // Outputs: Subtracting 5 from 2: 3
        Console.WriteLine($"Multiplying 5 by 2: {mathProxy.Mul(5, 2)}");  // Outputs: Multiplying 5 by 2: 10
        Console.WriteLine($"Dividing 5 by 2: {mathProxy.Div(5, 2)}");  // Outputs: Dividing 5 by 2: 2.5


        // Wait for user
        Console.ReadKey();
    }
}