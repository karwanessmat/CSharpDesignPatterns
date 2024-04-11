using Mediator0Demo._01_DefineMediatorInterface;
using Mediator0Demo._03_DefineComponentBaseClass;

namespace Mediator0Demo._04_CreateConcreteComponents;

public class Component1(IMediator mediator) : BaseComponent(mediator)
{
    public void DoA()
    {
        Console.WriteLine("Component 1 does A.");
        mediator?.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Component 1 does B.");
        mediator?.Notify(this, "B");
    }
}