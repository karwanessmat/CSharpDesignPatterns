using Mediator3Demo._01_DefineMediatorInterface;

namespace Mediator3Demo._03_DefineComponentBaseClass;

public abstract class Control(IMediator mediator)
{
    protected IMediator Mediator = mediator;


}
