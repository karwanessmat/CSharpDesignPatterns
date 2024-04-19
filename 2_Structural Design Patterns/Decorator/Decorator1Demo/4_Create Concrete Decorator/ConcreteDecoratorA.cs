using Decorator1Demo._1_Component_Interface;
using Decorator1Demo._3__Create_an_Abstract_Decorator;

namespace Decorator1Demo._4_Create_Concrete_Decorator;
    public class ConcreteDecoratorA(IComponent component) :Decorate(component)
    {
        public override string Operation()
        {
            return $"{nameof(ConcreteDecoratorA)}({base.Operation()})";
        }
    }