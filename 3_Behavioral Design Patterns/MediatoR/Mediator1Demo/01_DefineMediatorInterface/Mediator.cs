using Mediator1Demo._03_DefineComponentBaseClass;

namespace Mediator1Demo._01_DefineMediatorInterface;

/// <summary>
/// The 'Mediator' abstract class
/// </summary>
public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}