
using Mediator3Demo._02_CreateConcreteMediator;
using Mediator3Demo._04_CreateConcreteComponents;


var mediator = new DialogMediator();
var button = new Button(mediator);
var textField = new TextField(mediator);

mediator.Button = button;
mediator.TextField = textField;

button.Click();
Console.WriteLine();
Console.WriteLine();
textField.EnterText("New Text");

Console.ReadKey();