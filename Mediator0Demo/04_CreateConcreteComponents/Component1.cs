using Mediator0Demo._01_DefineMediatorInterface;
using Mediator0Demo._03_DefineComponentBaseClass;

namespace Mediator0Demo._04_CreateConcreteComponents;

public class Component1(IMediator mediator) : BaseComponent(mediator)
{
    private readonly IMediator _mediator = mediator;

    public void DoA()
    {
        Console.WriteLine("Component 1 does A.");
        _mediator?.Notify(this, "A");
    }

    public void DoB()
    {
        Console.WriteLine("Component 1 does B.");
        _mediator?.Notify(this, "B");
    }
}