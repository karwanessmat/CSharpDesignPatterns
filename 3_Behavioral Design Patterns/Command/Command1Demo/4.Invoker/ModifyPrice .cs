using System.Collections.Generic;
using System.Linq;
using Command1Demo._1.Command_Interface;

namespace Command1Demo._4.Invoker;

public class ModifyPrice
{
    private readonly List<ICommand> _commands = new();
    private ICommand _command;

    public void SetCommand(ICommand command) => _command = command;

    public void Invoke()
    {
        _commands.Add(_command);
        _command.ExecuteAction();
    }


    public void UndoActions()
    {
        foreach (var command in Enumerable.Reverse(_commands))
        {
            command.UndoAction();
        }
    }
}