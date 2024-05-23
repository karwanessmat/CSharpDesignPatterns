using Mediator1Demo._01_DefineMediatorInterface;
using Mediator1Demo._03_DefineComponentBaseClass;
using Mediator1Demo._04_CreateConcreteComponents;

namespace Mediator1Demo._02_CreateConcreteMediator;

/// <summary>
/// The 'ConcreteMediator' class
/// </summary>
internal class ConcreteMediator : Mediator

{
    public ConcreteColleague1 Colleague1 { get; set; }
    public ConcreteColleague2 Colleague2 { get; set; }




    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
        {
            Colleague2.Notify(message);
        }
        else

        {
            Colleague1.Notify(message);
        }
    }
}