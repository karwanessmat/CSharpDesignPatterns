using Mediator4Demo._01_DefineMediatorInterface;
using Mediator4Demo._03_DefineComponentBaseClass;

namespace Mediator4Demo._02_CreateConcreteMediator;

public class ConcreteMediator:Mediator
{
    //public Colleague1 Colleague1 { get; set; }
    //public Colleague2 Colleague2 { get; set; }

    private readonly List<Colleague> _colleagueList = [];

    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        _colleagueList.Add(colleague);
    }

    public T CreateColleague<T>() where T : Colleague, new()
    {
        var c = new T();
        c.SetMediator(this);
        _colleagueList.Add(c);
        return c;
    }

    public override void Send(string message, Colleague colleague)
    {
        //if (colleague == this.Colleague1)
        //{
        //    this.Colleague2.HandleNotification(message);
        //}
        //else
        //{
        //    this.Colleague1.HandleNotification(message);
        //}

        _colleagueList
            //.Where(c=>c !=colleague)
            .ToList()
            .ForEach(c=>c.HandleNotification(message));
    }
}