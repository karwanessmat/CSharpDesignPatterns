using System;

namespace Strategy1Demo.ConcreteStrategy
{
    class ConcreteStrategyB:Strategy.Strategy
    {
        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
