using Decorator5Demo._1_Component_Interface;

namespace Decorator5Demo._2_Create_a_Concrete_Component;

public class EmailNotifier:INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}