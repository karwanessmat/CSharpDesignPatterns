using System.Collections.Generic;
using Mediator2Demo._01_DefineMediatorInterface;
using Mediator2Demo._03_DefineComponentBaseClass;

namespace Mediator2Demo._02_CreateConcreteMediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// Inheritance of AbstractChatRoom
    /// </summary>
    public class ChatRoom : ICharRoom
    {

        /// <summary>
        /// An object to get Concrete Colleagues
        /// </summary>
        private readonly Dictionary<string, Participant> _participants = new();

        public  void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.ChatRoom = this;
        }

        public  void Send(string from, string to, string message)
        {
            var participant = _participants[to];

            participant?.ReceiveFrom(@from, message);
        }
    }
}
