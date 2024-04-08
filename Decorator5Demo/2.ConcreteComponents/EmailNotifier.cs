using Decorator5Demo._1.Component;

namespace Decorator5Demo._2.ConcreteComponents;

public class EmailNotifier:INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}