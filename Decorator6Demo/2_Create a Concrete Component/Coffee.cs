using Decorator6Demo._1_Component_Interface;

namespace Decorator6Demo._2_Create_a_Concrete_Component
{
    public class Coffee:ICoffee
    {
        public string Serve()
        {
            return "Coffee";
        }
    }
}
