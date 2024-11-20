namespace Mediator10Demo._01_DefineMediatorInterface;

public interface IMediator
{
    void Notify(object sender, string eventMessage);
}
