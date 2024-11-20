using Mediator10Demo._01_DefineMediatorInterface;
using Mediator10Demo._03_DefineComponentBaseClass;

namespace Mediator10Demo._04_CreateConcreteComponents;

public class Light(IMediator mediator) : SmartDevice(mediator)
{
    public void TurnOn()
    {
        Console.WriteLine("Light: Turning on.");
        Mediator.Notify(this, "LightOn");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light: Turning off.");
        Mediator.Notify(this, "LightOff");
    }
}