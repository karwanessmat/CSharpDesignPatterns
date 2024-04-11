using Mediator0Demo._02_CreateConcreteMediator;
using Mediator0Demo._04_CreateConcreteComponents;

var mediator = new ConcreteMediator();
var component1 = new Component1(mediator);
var component2 = new Component2(mediator);

mediator.Component1 = component1;
mediator.Component2 = component2;

component1.DoA();
Console.WriteLine();
component2.DoD();