using System;
using Mediator1Demo.ColleagueColleague;

namespace Mediator1Demo
{
    internal class Program
    {
        static void Main()
        {
            var m = new ConcreteMediator.ConcreteMediator();

            var c1 = new ConcreteColleague1(m);
            var c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");
            
            c1.Send("Are you coming with us to play football");
            c2.Send("I will let you know");

            // Wait for user

            Console.ReadKey();
        }
    }
}
