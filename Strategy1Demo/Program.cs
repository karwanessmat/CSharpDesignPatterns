using System;
using Strategy1Demo.ConcreteStrategy;

namespace Strategy1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Context.Context context;

            context = new Context.Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context.Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context.Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
