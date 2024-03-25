using System;

namespace State1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());

            // issue request which toggles state

            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();


            // Wait for user
            Console.ReadKey();
        }
    }
}
