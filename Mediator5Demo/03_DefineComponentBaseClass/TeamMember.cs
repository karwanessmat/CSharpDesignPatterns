using Mediator5Demo._01_DefineMediatorInterface;

namespace Mediator5Demo._03_DefineComponentBaseClass
{
    public abstract class TeamMember(string name)
    {
        private Chatroom chatroom;

        public string Name { get; } = name;

        internal void SetChatroom(Chatroom chatroom)
        {
            this.chatroom = chatroom;
        }

        public void Send(string message)
        {
            this.chatroom.Send(this, this.Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"from {from}: '{message}'");
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            this.chatroom.SendTo<T>(this.Name, message);
        }
    }
}
