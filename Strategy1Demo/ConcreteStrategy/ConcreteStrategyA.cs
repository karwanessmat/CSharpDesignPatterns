using System;

namespace Strategy1Demo.ConcreteStrategy
{
    class ConcreteStrategyA: Strategy.Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface");
        }
    }
}
