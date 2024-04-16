using Mediator3Demo._03_DefineComponentBaseClass;
using Mediator3Demo._01_DefineMediatorInterface;

namespace Mediator3Demo._04_CreateConcreteComponents;

public class Button(IMediator mediator): Control(mediator)
{
    public void Click()
    {
        Console.WriteLine("Button Clicked");
        Mediator.Notify(this, "click");
    }
}