using System;
using Mediator2Demo._02_CreateConcreteMediator;

namespace Mediator2Demo._03_DefineComponentBaseClass
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    public abstract class Participant(string name)
    {

        // Gets participant name
        public string Name { get; } = name;

        // Gets chatRoom
        public ChatRoom ChatRoom { set; get; }

        // Sends message to given participant
        public void SendTo(string to, string message)
        {
            ChatRoom.Send(Name, to, message);
        }
        
        // Receives message from given participant
        public virtual void ReceiveFrom(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }
}
