using Mediator9Demo._01_DefineMediatorInterface;
using Mediator9Demo._03_DefineComponentBaseClass;

namespace Mediator9Demo._04_CreateConcreteComponents;

public class Light : SmartDevice
{
    public Light(ISmartHomeMediator mediator) : base(mediator) { }

    public void TurnOn()
    {
        Console.WriteLine("Light: Turned on.");
    }

    public void Dim()
    {
        Console.WriteLine("Light: Dimmed.");
    }
}