using System;
using Strategy1Demo._2_Concrete_Strategies;
using Strategy1Demo._3_ContextClass;

namespace Strategy1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
