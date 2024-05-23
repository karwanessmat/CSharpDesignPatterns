using System;
using Mediator2Demo._03_DefineComponentBaseClass;

namespace Mediator2Demo._04_CreateConcreteComponents;

/// <summary>
/// A 'ConcreteColleague' class
/// </summary>
internal class Group1(string name) : Participant(name)
{
    // Constructor

    public override void ReceiveFrom(string from, string message)
    {
        Console.Write("To a Beatle: ");
        base.ReceiveFrom(from, message);
    }
}