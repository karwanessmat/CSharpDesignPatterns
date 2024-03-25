using System;
using System.Collections.Generic;
using Observer3Demo.Observer;
using Observer3Demo.Subject;

namespace Observer3Demo.ConcreteSubject
{
    public class Subject:ISubject
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string Availability { get; set; }

        readonly List<IObserver> _observers = new List<IObserver>();

        public Subject(string productName, double productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }
        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine($"Observer added {((ConcreteObserver.Observer)observer).UserName}");
            _observers.Add(observer);
        }

        public void AddObservers(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            Console.WriteLine($"Product Name: {ProductName}, product Price: {ProductPrice}, is now available. so notifying all registered");
            Console.WriteLine();
            foreach (var observer in _observers)
            {
                observer.Update(Availability);
            }
        }
    }
}
