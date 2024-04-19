using System;
using Observer2Demo.Step3_Implement_Concrete_Subject;
using Observer2Demo.Step4_Implement_Concrete_Observers;

namespace Observer2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibm = new Ibm("IBM",250);
            ibm.Attach(new Investor("Network"));
            ibm.Attach(new Investor("Personal Computer"));
            ibm.Attach(new Investor("Personal test"));

            // Fluctuating prices will notify investors
            ibm.Price = 250.55;
            ibm.Price = 150;
            ibm.Price = 177.88;
            ibm.Price = 250;

            Console.ReadKey();
        }
    }
}

//### Example Scenario and Result
//### In the above implementation, the Program class acts as the client. It:
//1. Creates an instance of the ConcreteSubject.
//2. Creates two observers, observer1 and observer2.
//3. Registers both observers with the subject.
//4. Changes the state of the subject, which triggers a notification to all registered observers.
