using System;
using Observer1Demo.Step3_Implement_Concrete_Subject;
using Observer1Demo.Step4_Implement_Concrete_Observers;

namespace Observer1Demo;

class Program
{
    static void Main(string[] args)
    {

        // Configure Observer pattern
        var s = new ConcreteSubject();
        s.Attach(new ConcreteObserver(s, "X"));
        s.Attach(new ConcreteObserver(s, "Y"));
        s.Attach(new ConcreteObserver(s, "Z"));
       
        // Change subject and notify observers
        s.SubjectState = "ABC";
        s.Notify();

        Console.WriteLine("Enter new state:");
        string newSate = Console.ReadLine();
        s.Attach(new ConcreteObserver(s,newSate));
        s.SubjectState = "ABC2";
        s.Notify();

        // Wait for user
        Console.ReadKey();
    }
}


//### Example Scenario and Result
//### In the above implementation, the Program class acts as the client. It:
//1. Creates an instance of the ConcreteSubject.
//2. Creates two observers, observer1 and observer2.
//3. Registers both observers with the subject.
//4. Changes the state of the subject, which triggers a notification to all registered observers.
