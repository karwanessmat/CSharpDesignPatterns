using Decorator5Demo._1.Component;

namespace Decorator5Demo._2.ConcreteComponents;

public class EmailAndSmsNotifiers(INotifier notifier) : INotifier
{
    public void Send(string message)
    {
        // Code to send SMS notification
        Console.WriteLine($"Sms: {message}");

        notifier.Send(message); // This also sends the email notification
    }
}