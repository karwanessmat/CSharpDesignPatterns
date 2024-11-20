using Mediator10Demo._01_DefineMediatorInterface;
using Mediator10Demo._03_DefineComponentBaseClass;

namespace Mediator10Demo._04_CreateConcreteComponents;

public class Fan(IMediator mediator) : SmartDevice(mediator)
{
    public void TurnOn() => Console.WriteLine("Fan: Turning on.");
    public void TurnOff() => Console.WriteLine("Fan: Turning off.");
}