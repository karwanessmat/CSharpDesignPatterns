using System;
using Observer1Demo.Step1_Define_Observer_Interface;
using Observer1Demo.Step3_Implement_Concrete_Subject;

namespace Observer1Demo.Step4_Implement_Concrete_Observers;

/// <summary>
/// step4: Create Concrete Observer Classes: These classes implement the Observer interface and define how they should update when notified by the Subject.
/// </summary>
public class ConcreteObserver(ConcreteSubject subject, string name) : Observer
{
    private string _observerState;
    // Gets or sets subject
    public ConcreteSubject Subject { get; set; } = subject;

    // Constructor
    public override void Update()
    {
        _observerState = Subject.SubjectState;
        Console.WriteLine("Observer {0}'s new state is {1}",
            name, _observerState);
    }

}