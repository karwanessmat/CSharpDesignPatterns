using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy1Demo.Context
{
    class Context
    {
        private Strategy.Strategy _strategy;

        public Context(Strategy.Strategy strategy)
        {
            _strategy = strategy;
        }


        public void ContextInterface()
        {

            _strategy.AlgorithmInterface();
        }
    }
}
