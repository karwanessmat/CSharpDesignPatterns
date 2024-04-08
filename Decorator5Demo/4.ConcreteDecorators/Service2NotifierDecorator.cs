using Decorator5Demo._1.Component;
using Decorator5Demo._3.Decorator;

namespace Decorator5Demo._4.ConcreteDecorators;

public class Service2NotifierDecorator(INotifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send($"Service 2 {message}");
    }
}