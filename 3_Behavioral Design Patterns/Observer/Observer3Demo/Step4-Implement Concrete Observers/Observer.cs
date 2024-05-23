using System;
using Observer3Demo.Step1_Define_Observer_Interface;
using Observer3Demo.Step2_Define_Subject_Interface;

namespace Observer3Demo.Step4_Implement_Concrete_Observers;

public class Observer: IObserver
{
    public string UserName { get; set; }

    public Observer(string userName, ISubject subject)
    {
        UserName = userName;
        subject.RegisterObserver(this);
    }

    public void Update(string availability)
    {
        Console.WriteLine($"Hello {UserName} product is now {availability} on High Plan");
    }
}