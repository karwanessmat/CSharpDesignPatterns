using Mediator9Demo._01_DefineMediatorInterface;
using Mediator9Demo._03_DefineComponentBaseClass;

namespace Mediator9Demo._04_CreateConcreteComponents;

public class Speaker : SmartDevice
{
    public Speaker(ISmartHomeMediator mediator) : base(mediator) { }

    public void Play(string message)
    {
        Console.WriteLine($"Speaker: {message}");
    }

    public void TriggerAlarm()
    {
        Console.WriteLine("Speaker: Alarm triggered!");
        Mediator.Notify(nameof(Speaker), "Alarm");
    }
}