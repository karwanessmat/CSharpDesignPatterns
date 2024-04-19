using Mediator7Demo._03_DefineComponentBaseClass;

namespace Mediator7Demo._01_DefineMediatorInterface;

internal interface IMediator
{
    void Register(string key, IParticipant participant);
    void SendCommand(string receiver, string sender, string command);
}