using Mediator7Demo._01_DefineMediatorInterface;
using Mediator7Demo._03_DefineComponentBaseClass;

namespace Mediator7Demo._04_CreateConcreteComponents;

internal class Server(string key,IMediator mediator) : Participant(key, mediator)
{
    public override void SendCommand(string receiver, string command)
    {
        Console.WriteLine($"Server has issued {command} command to {receiver}.");
        base.SendCommand(receiver, command);
    }

    public override void ReceiveCommand(string sender, string command)
    {
        Console.Write($"Server {Key} received a command. ");
        base.ReceiveCommand(sender, command);
    }
}