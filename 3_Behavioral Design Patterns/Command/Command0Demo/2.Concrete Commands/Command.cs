using Command0Demo._1.Command_Interface;

namespace Command0Demo._2.Concrete_Commands;

/// <summary>
/// a special one to invoke action
/// </summary>
/// <param name="action"></param>
public class Command(Action action):ICommand
{
    public void Execute()
    {
        action();
    }
}