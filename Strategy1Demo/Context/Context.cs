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
