using Mediator9Demo._01_DefineMediatorInterface;
using Mediator9Demo._03_DefineComponentBaseClass;

namespace Mediator9Demo._04_CreateConcreteComponents;

public class Thermostat : SmartDevice
{
    public Thermostat(ISmartHomeMediator mediator) : base(mediator) { }

    public void DetectHighTemperature()
    {
        Console.WriteLine("Thermostat: High temperature detected!");
        Mediator.Notify(nameof(Thermostat), "TemperatureHigh");
    }
}