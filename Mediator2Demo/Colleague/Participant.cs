using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator2Demo.ConcreteMediator;

namespace Mediator2Demo.Colleague
{
    /// <summary>
    /// The 'AbstractColleague' class
    /// </summary>
    internal class Participant
    {
        // Constructor
        public Participant(string name)
        {
            Name = name;
        }

        // Gets participant name
        public string Name { get; }

        // Gets chatRoom
        public ChatRoom ChatRoom { set; get; }

        // Sends message to given participant
        public void Send(string to, string message)
        {
            ChatRoom.Send(Name, to, message);
        }
        
        // Receives message from given participant
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",
                from, Name, message);
        }
    }
}
