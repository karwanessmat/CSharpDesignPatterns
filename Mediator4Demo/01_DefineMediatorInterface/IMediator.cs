using Mediator4Demo._03_DefineComponentBaseClass;

namespace Mediator4Demo._01_DefineMediatorInterface
{
    public abstract class  Mediator
    {
        public abstract void Send(string message,Colleague colleague);
    }
}
