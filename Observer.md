
# Observer Design Pattern 

## Definition

The Observer design pattern is a software design pattern that allows an object, known as the subject, to notify other interested objects, known as observers, of changes in its state. This pattern is particularly useful for creating an efficient communication system where changes to one object can be automatically propagated to others that depend on it, without making the objects tightly coupled.


### Frequency of Use
`5/5` - Highly utilized in .NET design patterns

## Real-World Scenario

Consider a weather station that measures temperature, humidity, and pressure. Multiple displays, like a current conditions display, a statistics display, and a forecast display, need to update their readings whenever the weather station records new data. Each display reacts differently to the same data input.

## Problem

The challenge is managing the updating of multiple displays when the weather station's data changes. If each display directly retrieves data from the weather station, the system becomes tightly coupled and hard to manage as more displays or different types of displays are added.

## Solution to the Problem

The Observer pattern addresses this problem by allowing the weather station to broadcast its state changes to registered displays, which can then update themselves independently. This decouples the weather station from the displays, making the system more modular, easier to extend, and maintain.



## Steps to Implement the Observer Pattern
1. **Define the Observer Interface:** This interface allows the Subject to communicate with its observers when its state changes.
2. **Define the Subject Interface:** This interface manages the list of observers and includes methods for adding, removing, and notifying observers.
3. **Create Concrete Observer Classes:** These classes implement the Observer interface and define how they should update when notified by the Subject.
4. **Create Concrete Subject Class:** This class implements the Subject interface. It maintains a list of its observers and communicates with them as needed.
5. **Client:** In the client code, create instances of the Subject and Observers, register the Observers with the Subject, and trigger updates.




## Observer's Structure

1. **Subject (Observable)**: An interface or abstract class maintaining a list of observers, adding or removing observers from that list, and notifying them of state changes.
2. **ConcreteSubject**: Inherits from Subject, maintains the state of the object and notifies observers when the state changes.
3. **Observer**: An interface or abstract class defining the `Update()` method that will be called when the Subject changes.
4. **ConcreteObserver**: Implements the Observer interface and reacts to notifications from the Subject.

## Implementation Steps

### Step 1: Define Observer Interface
Create an interface that defines the `Update()` method. This method is called to notify the observing objects of a change.

```csharp
public interface IObserver
{
    void Update();
}
```

### Step 2: Define Subject Interface
Define an interface for the subject with methods to attach, detach, and notify observers.

```csharp
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
```

### Step 3: Implement Concrete Subject
Implement the subject interface in a concrete subject class. This class holds the state and notifies observers about state changes.

```csharp
public class WeatherStation : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private int _temperature;

    public int Temperature
    {
        get { return _temperature; }
        set { _temperature = value; Notify(); }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update();
        }
    }
}
```

### Step 4: Implement Concrete Observers
Create concrete observer classes that implement the observer interface. Each observer updates itself in response to a notification.

```csharp
public class CurrentConditionsDisplay : IObserver
{
    private WeatherStation _weatherStation;

    public CurrentConditionsDisplay(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine("Current conditions: " + _weatherStation.Temperature + "F degrees.");
    }
}
```

### Step 5: Using the Pattern
Create a `WeatherStation` object and several display objects. Changing the state of the `WeatherStation` will notify the displays, which will then update themselves.

```csharp
var weatherStation = new WeatherStation();
var currentDisplay = new CurrentConditionsDisplay(weatherStation);

weatherStation.Temperature = 70;  // Both observers are notified and updated.
```

## Summary

The Observer pattern provides a flexible and scalable way to handle state change notifications in a software system. By decoupling the subjects from their observers, it promotes a robust design that is easier to modify and extend. This pattern is extensively used in real-world applications where changes to one component need to be propagated to others without creating a tight coupling between them.