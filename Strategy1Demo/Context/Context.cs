namespace Strategy1Demo.Context
{
    class Context(Strategy.Strategy strategy)
    {
        public void ContextInterface()
        {

            strategy.AlgorithmInterface();
        }
    }
}
