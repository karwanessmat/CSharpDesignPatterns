using Mediator7Demo._01_DefineMediatorInterface;
using Mediator7Demo._03_DefineComponentBaseClass;

namespace Mediator7Demo._02_CreateConcreteMediator;

internal class NetworkMediator : IMediator
{
    private readonly Dictionary<string, IParticipant> _participants = [];



    public void Register(string key, IParticipant participant)
    {
        _participants[key] = participant;
    }

    public void SendCommand(string receiver, string sender, string command)
    {
        if (_participants.TryGetValue(receiver, out var participant))
        {
            participant.ReceiveCommand(sender, command);
        }
    }
}