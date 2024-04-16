using Decorator5Demo._1_Component_Interface;

namespace Decorator5Demo._2_Create_a_Concrete_Component;

public class EmailAndSmsNotifiers(INotifier notifier) : INotifier
{
    public void Send(string message)
    {
        // Code to send SMS notification
        Console.WriteLine($"Sms: {message}");

        notifier.Send(message); // This also sends the email notification
    }
}