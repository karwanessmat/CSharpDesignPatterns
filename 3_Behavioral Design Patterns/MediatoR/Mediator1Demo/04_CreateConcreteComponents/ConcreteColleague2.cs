using System;
using Mediator1Demo._01_DefineMediatorInterface;
using Mediator1Demo._03_DefineComponentBaseClass;

namespace Mediator1Demo._04_CreateConcreteComponents;

/// <summary>
/// A 'ConcreteColleague' class
/// </summary>
internal class ConcreteColleague2(Mediator mediator) : Colleague(mediator)
{


    public void SendMessage(string message)
    {
        Mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine("Colleague2 gets message: " + message);
    }
}