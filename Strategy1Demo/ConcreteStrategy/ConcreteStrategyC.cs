using System;

namespace Strategy1Demo.ConcreteStrategy
{
    class ConcreteStrategyC:Strategy.Strategy
    {
        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
