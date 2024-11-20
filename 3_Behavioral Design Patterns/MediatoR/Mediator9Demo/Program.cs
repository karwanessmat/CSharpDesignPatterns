using Mediator9Demo._02_CreateConcreteMediator;
using Mediator9Demo._04_CreateConcreteComponents;

var mediator = new SmartHomeMediator();

var light = new Light(mediator);
var thermostat = new Thermostat(mediator);
var speaker = new Speaker(mediator);

mediator.Light = light;
mediator.Thermostat = thermostat;
mediator.Speaker = speaker;

// Simulate high temperature event
thermostat.DetectHighTemperature();

Console.WriteLine();
Console.WriteLine();
// Simulate alarm event
speaker.TriggerAlarm();