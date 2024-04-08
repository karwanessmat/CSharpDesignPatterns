using Decorator1Demo._1.Component;
using Decorator1Demo._3.Decorate;

namespace Decorator1Demo._4.ConcreteDecorates;
    public class ConcreteDecoratorA(IComponent component) :Decorate(component)
    {
        public override string Operation()
        {
            return $"{nameof(ConcreteDecoratorA)}({base.Operation()})";
        }
    }