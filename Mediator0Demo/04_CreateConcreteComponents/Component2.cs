using Mediator0Demo._01_DefineMediatorInterface;
using Mediator0Demo._03_DefineComponentBaseClass;

namespace Mediator0Demo._04_CreateConcreteComponents;

public class Component2(IMediator mediator) : BaseComponent(mediator)
{
    public void DoC()
    {
        Console.WriteLine("Component 2 does C.");
        mediator?.Notify(this, "C");
    }

    public void DoD()
    {
        Console.WriteLine("Component 2 does D.");
        mediator?.Notify(this, "D");
    }
}