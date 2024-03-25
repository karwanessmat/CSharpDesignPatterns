using System;
using Mediator2Demo.Colleague;

namespace Mediator2Demo.ColleagueColleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>

    class NonBeatle : Participant
    {
        // Constructor
        public NonBeatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
