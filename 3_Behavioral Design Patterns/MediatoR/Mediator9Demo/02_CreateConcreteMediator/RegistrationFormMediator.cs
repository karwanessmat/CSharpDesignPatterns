using Mediator9Demo._01_DefineMediatorInterface;
using Mediator9Demo._04_CreateConcreteComponents;

namespace Mediator9Demo._02_CreateConcreteMediator;

public class SmartHomeMediator : ISmartHomeMediator
{
    public Light Light { get; set; }
    public Thermostat Thermostat { get; set; }
    public Speaker Speaker { get; set; }

    public void Notify(string sender, string eventMessage)
    {
        if (sender == nameof(Thermostat) && eventMessage == "TemperatureHigh")
        {
            Console.WriteLine("Mediator: Temperature is high. Turning on the AC and dimming the lights.");
            Light.Dim();
            Speaker.Play("Cooling mode activated!");
        }
        else if (sender == nameof(Speaker) && eventMessage == "Alarm")
        {
            Console.WriteLine("Mediator: Alarm triggered. Turning on the lights and alerting.");
            Light.TurnOn();
        }
    }
}
