using Command0Demo._1.Command_Interface;

namespace Command0Demo._2.Concrete_Commands;

internal class SaveCommand : ICommand
{
    public void Execute()
    {
        // logic
        Console.WriteLine("Save command");
    }
}