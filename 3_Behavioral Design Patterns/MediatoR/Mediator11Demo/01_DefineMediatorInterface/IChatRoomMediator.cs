using Mediator11Demo._03_DefineComponentBaseClass;

namespace Mediator11Demo._01_DefineMediatorInterface;

public interface IChatRoomMediator
{
    void RegisterUser(User user);
    void SendMessage(string message, string sender, string receiver);
}
