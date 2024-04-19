using Mediator3Demo._03_DefineComponentBaseClass;

namespace Mediator3Demo._01_DefineMediatorInterface;

public interface IMediator
{
    void Notify(Control sender, string @event);
}
