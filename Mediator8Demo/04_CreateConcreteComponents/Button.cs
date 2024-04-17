using Mediator8Demo._01_DefineMediatorInterface;
using Mediator8Demo._03_DefineComponentBaseClass;

namespace Mediator8Demo._04_CreateConcreteComponents;

public class Button(IMediator mediator) : Component(mediator)
{
    public bool IsEnabled { get; set; }
}