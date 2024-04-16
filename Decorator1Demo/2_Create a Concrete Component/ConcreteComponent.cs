using Decorator1Demo._1_Component_Interface;

namespace Decorator1Demo._2_Create_a_Concrete_Component
{
    public class ConcreteComponent:IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
