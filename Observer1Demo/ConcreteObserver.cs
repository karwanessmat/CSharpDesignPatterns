using System;

namespace Observer1Demo
{
    /// <summary>
    /// The 'ConcreteObserver' class
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
}
