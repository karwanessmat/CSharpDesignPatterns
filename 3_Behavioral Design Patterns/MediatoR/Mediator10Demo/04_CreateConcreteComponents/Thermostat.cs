using Mediator10Demo._01_DefineMediatorInterface;
using Mediator10Demo._03_DefineComponentBaseClass;

namespace Mediator10Demo._04_CreateConcreteComponents;

public class Thermostat(IMediator mediator) : SmartDevice(mediator)
{
    public void SetTemperature(int temperature) =>
        Console.WriteLine($"Thermostat: Setting temperature to {temperature}°C.");
}