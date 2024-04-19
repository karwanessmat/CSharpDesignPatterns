using Mediator3Demo._01_DefineMediatorInterface;
using Mediator3Demo._03_DefineComponentBaseClass;

namespace Mediator3Demo._04_CreateConcreteComponents;

public class TextField(IMediator mediator) : Control(mediator)
{
    public void EnterText(string text)
    {
        Console.WriteLine($"Text entered: {text}");
        Mediator.Notify(this, "textChange");
    }

}