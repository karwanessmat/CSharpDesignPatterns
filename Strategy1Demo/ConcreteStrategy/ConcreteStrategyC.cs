using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
