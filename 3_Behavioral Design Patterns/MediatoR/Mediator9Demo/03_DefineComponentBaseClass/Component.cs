using Mediator9Demo._01_DefineMediatorInterface;

namespace Mediator9Demo._03_DefineComponentBaseClass;

public abstract class SmartDevice
{
    protected ISmartHomeMediator Mediator;

    public SmartDevice(ISmartHomeMediator mediator)
    {
        Mediator = mediator;
    }
}
