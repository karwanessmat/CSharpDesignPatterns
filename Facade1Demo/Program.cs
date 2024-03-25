using System;

namespace Facade1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var facade = new Facade();

            facade.CallSubSystemsMethod();

            // Wait for user

            Console.ReadKey();

        }
    }
}
