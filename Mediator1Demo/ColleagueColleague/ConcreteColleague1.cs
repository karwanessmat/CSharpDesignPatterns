using System;

namespace Mediator1Demo.ColleagueColleague
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    internal class ConcreteColleague1(Mediator.Mediator mediator) : Colleague.Colleague(mediator)

    {
        // Constructor

        public void Send(string message)
        {
            
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }
}
