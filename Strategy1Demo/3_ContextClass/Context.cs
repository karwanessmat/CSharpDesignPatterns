using Strategy1Demo._1_Define_Strategy_Interface;

namespace Strategy1Demo._3_ContextClass
{
   public class Context(Strategy strategy)
    {
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
