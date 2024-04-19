using System;
using Mediator1Demo._02_CreateConcreteMediator;
using Mediator1Demo._04_CreateConcreteComponents;

namespace Mediator1Demo
{
    internal class Program
    {
        static void Main()
        {
            var mediator = new ConcreteMediator();

            var c1 = new ConcreteColleague1(mediator);
            var c2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            c1.SendMessage("How are you?");
            c2.SendMessage("Fine, thanks");
            
            c1.SendMessage("Are you coming with us to play football");
            c2.SendMessage("I will let you know");

            // Wait for user

            Console.ReadKey();
        }
    }
}
