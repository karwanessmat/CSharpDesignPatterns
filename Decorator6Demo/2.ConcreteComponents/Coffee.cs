using Decorator6Demo._1.Component;

namespace Decorator6Demo._2.ConcreteComponents
{
    public class Coffee:ICoffee
    {
        public string Serve()
        {
            return "Coffee";
        }
    }
}
