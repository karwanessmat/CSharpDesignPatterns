using Mediator10Demo._01_DefineMediatorInterface;

namespace Mediator10Demo._03_DefineComponentBaseClass;

public abstract class SmartDevice(IMediator mediator)
{
    protected IMediator Mediator = mediator;
}
