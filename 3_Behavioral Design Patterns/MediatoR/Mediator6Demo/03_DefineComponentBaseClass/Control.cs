using Mediator6Demo._01_DefineMediatorInterface;

namespace Mediator6Demo._03_DefineComponentBaseClass;

public class Control(IWindow owner)
{
    protected IWindow owner = owner;
}