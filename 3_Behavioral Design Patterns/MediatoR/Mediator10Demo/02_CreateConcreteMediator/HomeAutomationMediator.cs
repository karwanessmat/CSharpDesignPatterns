using Mediator10Demo._01_DefineMediatorInterface;
using Mediator10Demo._04_CreateConcreteComponents;

namespace Mediator10Demo._02_CreateConcreteMediator;

public class HomeAutomationMediator : IMediator
{
    public Light Light { get; set; }
    public Fan Fan { get; set; }
    public Thermostat Thermostat { get; set; }

    public void Notify(object sender, string eventMessage)
    {
        if (eventMessage == "LightOn")
        {
            Console.WriteLine("Mediator: Light is turned on. Adjusting other devices...");
            Fan.TurnOn();
            Thermostat.SetTemperature(22);
        }
        else if (eventMessage == "LightOff")
        {
            Console.WriteLine("Mediator: Light is turned off. Turning off other devices...");
            Fan.TurnOff();
        }
    }
}
