using System;
using System.Collections.Generic;
using Observer3Demo.Step1_Define_Observer_Interface;
using Observer3Demo.Step2_Define_Subject_Interface;
using Observer3Demo.Step4_Implement_Concrete_Observers;

namespace Observer3Demo.Step3_Implement_Concrete_Subject;

public class Subject(string productName, double productPrice, string availability)
    : ISubject
{
    public string ProductName { get; set; } = productName;
    public double ProductPrice { get; set; } = productPrice;
    public string Availability { get; set; } = availability;

    private readonly List<IObserver> _observers = [];

    public string GetAvailability()
    {
        return Availability;
    }
    public void SetAvailability(string availability)
    {
        Availability = availability;
        Console.WriteLine("Availability changed from Out of Stock to Available.");
        NotifyObserver();
    }

    public void RegisterObserver(IObserver observer)
    {
        Console.WriteLine($"Observer added {((Observer)observer).UserName}");
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
        foreach (IObserver observer in _observers)
        {
            observer.Update(Availability);
        }
    }
}