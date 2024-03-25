using System;

namespace Observer1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
       
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            Console.WriteLine("Enter new state:");
            var newSate = Console.ReadLine();
            s.Attach(new ConcreteObserver(s,newSate));
            s.SubjectState = "ABC2";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }
    }
}
