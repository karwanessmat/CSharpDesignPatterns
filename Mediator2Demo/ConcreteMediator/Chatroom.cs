using System.Collections.Generic;
using Mediator2Demo.Colleague;
using Mediator2Demo.Mediator;

namespace Mediator2Demo.ConcreteMediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// Inheritance of AbstractChatRoom
    /// </summary>
    internal class ChatRoom : AbstractChatRoom
    {

        /// <summary>
        /// An object to get Concrete Colleagues
        /// </summary>
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.ChatRoom = this;
        }

        public override void Send(string from, string to, string message)
        {
            var participant = _participants[to];

            participant?.Receive(@from, message);
        }
    }
}
