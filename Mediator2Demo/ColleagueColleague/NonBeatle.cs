using System;
using Mediator2Demo.Colleague;

namespace Mediator2Demo.ColleagueColleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>

    class NonBeatle(string name) : Participant(name)
    {
        // Constructor

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
