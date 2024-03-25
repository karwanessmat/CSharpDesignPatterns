using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator2Demo.Colleague;

namespace Mediator2Demo.Mediator
{
    /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    internal abstract class AbstractChatRoom
    {
        /// <summary>
        /// Participant is abstract Colleague
        /// </summary>
        /// <param name="participant"></param>
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }
}
