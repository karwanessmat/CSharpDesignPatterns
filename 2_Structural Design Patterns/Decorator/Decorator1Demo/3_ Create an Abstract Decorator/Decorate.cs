using Decorator1Demo._1_Component_Interface;

namespace Decorator1Demo._3__Create_an_Abstract_Decorator;
    public abstract class Decorate(IComponent component):IComponent
    {
        public virtual string Operation()
        {
            return component.Operation();
        }
    }

