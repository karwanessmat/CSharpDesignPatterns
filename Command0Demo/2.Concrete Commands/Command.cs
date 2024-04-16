using Command0Demo._1.Command_Interface;

namespace Command0Demo._2.Concrete_Commands;

public class Command(Action action):ICommand
{
    public void Execute()
    {
        action();
    }
}