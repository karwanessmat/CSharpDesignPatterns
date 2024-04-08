using Decorator1Demo._1.Component;

namespace Decorator1Demo._3.Decorate;
    public abstract class Decorate(IComponent component):IComponent
    {
        public virtual string Operation()
        {
            return component.Operation();
        }
    }

