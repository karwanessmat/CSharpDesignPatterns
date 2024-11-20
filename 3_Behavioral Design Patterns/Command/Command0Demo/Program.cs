using Command0Demo._2.Concrete_Commands;
using Command0Demo._3.Receiver;

var openCommand = new CoolButton(new OpenCommand());
openCommand.Click();

var saveCommand = new CoolButton(new SaveCommand());
saveCommand.Click();

var deleteCommand = new CoolButton(new CoolButtonCommand(() =>
{
    Console.WriteLine("//Logic");
    var command = new DeleteCommand();
    command.Execute();
}));

// execute the logic
deleteCommand.Click();