using Mediator0Demo._01_DefineMediatorInterface;
using Mediator0Demo._04_CreateConcreteComponents;

namespace Mediator0Demo._02_CreateConcreteMediator;
public class ConcreteMediator : IMediator
{
    public Component1 Component1 { get; set; }
    public Component2 Component2 { get; set; }

    public void Notify(object sender, string eventMessage)
    {
        if (eventMessage == "A")
        {
            Console.WriteLine("Mediator reacts on A and triggers following operations:");
            Component2.DoC();
        }
        if (eventMessage == "D")
        {
            Console.WriteLine("Mediator reacts on D and triggers following operations:");
            Component1.DoB();
            Component2.DoC();
        }
    }
}

