using Mediator11Demo._01_DefineMediatorInterface;

namespace Mediator11Demo._03_DefineComponentBaseClass;
public abstract class User(string name)
{
    protected IChatRoomMediator ChatRoom;
    public string Name { get; } = name;

    public void SetChatRoom(IChatRoomMediator chatRoom)
    {
        ChatRoom = chatRoom;
    }

    public abstract void SendMessage(string message, string receiver);
    public abstract void ReceiveMessage(string message, string sender);
}

