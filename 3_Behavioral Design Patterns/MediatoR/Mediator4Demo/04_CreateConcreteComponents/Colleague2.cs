using Mediator4Demo._03_DefineComponentBaseClass;

namespace Mediator4Demo._04_CreateConcreteComponents;

public class Colleague2:Colleague
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague2 receives notification message: {message}");
    }
}