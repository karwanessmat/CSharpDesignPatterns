using System;
using Mediator2Demo._02_CreateConcreteMediator;
using Mediator2Demo._03_DefineComponentBaseClass;
using Mediator2Demo._04_CreateConcreteComponents;

namespace Mediator2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create chat Room

            var chatRoom = new ChatRoom();

            // Create participants and register them
            Participant george = new Group1("George");
            Participant paul = new Group1("Paul");
            Participant ringo = new Group1("Ringo");
            Participant john = new Group1("John");
            Participant yoko = new Group2("Yoko");

            chatRoom.Register(george);
            chatRoom.Register(paul);
            chatRoom.Register(ringo);
            chatRoom.Register(john);
            chatRoom.Register(yoko);

            // Chatting participants

            yoko.SendTo("John", "Hi John!");
            paul.SendTo("Ringo", "All you need is love");
            ringo.SendTo("George", "My sweet Lord");
            paul.SendTo("John", "Can't buy me love");
            john.SendTo("Yoko", "My sweet love");

            // Wait for user

            Console.ReadKey();
        }
    }
}
