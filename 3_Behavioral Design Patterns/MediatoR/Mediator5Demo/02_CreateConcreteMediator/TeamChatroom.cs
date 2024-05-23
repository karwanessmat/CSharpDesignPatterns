using Mediator5Demo._01_DefineMediatorInterface;
using Mediator5Demo._03_DefineComponentBaseClass;

namespace Mediator5Demo._02_CreateConcreteMediator;

public class TeamChatroom : Chatroom
{
    private readonly List<TeamMember> _members = [];

    public override void Register(TeamMember member)
    {
        member.SetChatroom(this);
        _members.Add(member);
    }

    public void RegisterMembers(params TeamMember[] teamMembers)
    {
        foreach (var member in teamMembers)
        { 
            Register(member);
        }
    }

    public override void Send(TeamMember member, string from, string message)
    {
        _members
            .Where(x=>x != member) // send message to all member except his self
            .ToList()
            .ForEach(m => m.Receive(from, message));
    }



    public override void SendTo<T>(string from, string message)
    {
        _members.OfType<T>().ToList().ForEach(m => m.Receive(from, message));
    }
}