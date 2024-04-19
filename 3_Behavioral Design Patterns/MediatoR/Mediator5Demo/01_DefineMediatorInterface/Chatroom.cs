using Mediator5Demo._03_DefineComponentBaseClass;

namespace Mediator5Demo._01_DefineMediatorInterface
{
    public abstract class Chatroom
    {
        public abstract void Register(TeamMember member);
        public abstract void Send(TeamMember member, string from, string message);
        public abstract void SendTo<T>(string from, string message) where T : TeamMember;

    }
}
