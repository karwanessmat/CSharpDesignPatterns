using Command00Demo._1.Command_Interface;

namespace Command00Demo._4.Invoker;

internal class DataCommandInvoker
{

    /// <summary>
    /// we did not inject constructor because we have more than one concrete commands 
    /// </summary>
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
        //Console.WriteLine($"Command {command.GetType()} set.");
    }

    public void ExecuteCommand()
    {
        _command?.Execute();
    }
}