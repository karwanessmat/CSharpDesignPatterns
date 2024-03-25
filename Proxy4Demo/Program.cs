using System;

namespace Proxy4Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new NewServerProxy();

            proxy.TakeOrder("121");
            Console.ReadLine();
        }
    }
}
