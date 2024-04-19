using Decorator5Demo._1_Component_Interface;
using Decorator5Demo._3__Create_an_Abstract_Decorator;

namespace Decorator5Demo._4_Create_Concrete_Decorator;

public class Service2NotifierDecorator(INotifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send($"Service 2 {message}");
    }
}