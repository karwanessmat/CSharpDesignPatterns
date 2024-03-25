using System;

namespace Observer1Demo
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class ConcreteObserver : Observer
    {
        private readonly string _name;
        private string _observerState;
        // Gets or sets subject
        public ConcreteSubject Subject { get; set; }

        // Constructor
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            _name = name;
        }
        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
                _name, _observerState);
        }

    }
}
