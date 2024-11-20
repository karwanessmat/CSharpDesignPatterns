using Mediator11Demo._03_DefineComponentBaseClass;

namespace Mediator11Demo._04_CreateConcreteComponents;

public class ChatUser(string name) : User(name)
{
    public override void SendMessage(string message, string receiver)
    {
        Console.WriteLine($"{Name} sends message to {receiver}: {message}");
        ChatRoom.SendMessage(message, Name, receiver);
    }

    public override void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"{Name} received message from {sender}: {message}");
    }
}