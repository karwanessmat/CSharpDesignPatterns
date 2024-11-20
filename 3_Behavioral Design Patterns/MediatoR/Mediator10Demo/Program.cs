using Mediator10Demo._02_CreateConcreteMediator;
using Mediator10Demo._04_CreateConcreteComponents;

var mediator = new HomeAutomationMediator();

var light = new Light(mediator);
var fan = new Fan(mediator);
var thermostat = new Thermostat(mediator);

mediator.Light = light;
mediator.Fan = fan;
mediator.Thermostat = thermostat;

light.TurnOn();
Console.WriteLine();
light.TurnOff();