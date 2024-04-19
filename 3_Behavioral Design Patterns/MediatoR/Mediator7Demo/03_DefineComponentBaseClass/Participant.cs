using Mediator7Demo._01_DefineMediatorInterface;

namespace Mediator7Demo._03_DefineComponentBaseClass;

internal abstract class Participant(string key, IMediator mediator) : IParticipant
{
    protected string Key = key;

    public virtual void SendCommand(string receiver, string command)
    {
        mediator.SendCommand(receiver, Key, command);
    }

    public virtual void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Executing command {command} issued by {sender}.");
    }
}