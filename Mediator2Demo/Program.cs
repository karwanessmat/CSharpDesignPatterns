using System;
using Mediator2Demo.Colleague;
using Mediator2Demo.ColleagueColleague;
using Mediator2Demo.ConcreteMediator;

namespace Mediator2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chat Room

            var chatRoom = new ChatRoom();

            // Create participants and register them
            Participant george = new Beatle("George");
            Participant paul = new Beatle("Paul");
            Participant ringo = new Beatle("Ringo");
            Participant john = new Beatle("John");
            Participant yoko = new NonBeatle("Yoko");

            chatRoom.Register(george);
            chatRoom.Register(paul);
            chatRoom.Register(ringo);
            chatRoom.Register(john);
            chatRoom.Register(yoko);

            // Chatting participants

            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
}
