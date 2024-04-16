using Decorator5Demo._1_Component_Interface;

namespace Decorator5Demo._3__Create_an_Abstract_Decorator
{
    public abstract class NotifierDecorator(INotifier notifier):INotifier
    {
        public virtual void Send(string message)
        {
            notifier.Send(message);
        }


    }
}
