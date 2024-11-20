using Mediator11Demo._01_DefineMediatorInterface;
using Mediator11Demo._03_DefineComponentBaseClass;

namespace Mediator11Demo._02_CreateConcreteMediator;

public class ChatRoomMediator : IChatRoomMediator
{
    private readonly Dictionary<string, User> _users = new();

    public void RegisterUser(User user)
    {
        if (_users.TryAdd(user.Name, user))
        {
            user.SetChatRoom(this);
        }
    }

    public void SendMessage(string message, string sender, string receiver)
    {
        if (_users.TryGetValue(receiver, out var user))
        {
            user.ReceiveMessage(message, sender);
        }
        else
        {
            Console.WriteLine($"User {receiver} not found!");
        }
    }
}