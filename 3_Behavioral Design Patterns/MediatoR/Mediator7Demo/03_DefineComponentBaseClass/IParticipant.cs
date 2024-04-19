namespace Mediator7Demo._03_DefineComponentBaseClass;

internal interface IParticipant
{
    void SendCommand(string receiver, string command);
    void ReceiveCommand(string sender, string command);
}