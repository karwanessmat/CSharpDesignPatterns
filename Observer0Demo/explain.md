
# Observer Pattern

This repository contains an implementation of the Observer pattern in C#. The Observer pattern allows an object (known as a "subject") to notify other objects (known as "observers") when its state changes.

## Structure

The implementation is divided into several steps:

1. **Define Observer Interface**
2. **Define Subject Interface**
3. **Implement Concrete Subject**
4. **Implement Concrete Observers**
5. **Demo Usage**

Each step is encapsulated in its namespace for clarity.

## Step 1: Define Observer Interface

The `IObserver` interface defines a single method `Update`, which is called when the Subject changes.

## Step 2: Define Subject Interface

The `ISubject` interface includes methods for subscribing and unsubscribing observers, as well as notifying these observers when a change occurs.

## Step 3: Implement Concrete Subject

`Publisher` is a concrete implementation of `ISubject`. It manages a list of observers and notifies them of messages.

## Step 4: Implement Concrete Observers

`Subscriber` is a concrete implementation of `IObserver` that simply prints out messages it receives along with the source.

## Step 5: Demo Usage

Demonstrates how to create a publisher and multiple subscribers, how they interact, and how subscribers can be dynamically added and removed.

## Installation

No specific installation steps required as this is a simple C# console application. Simply compile and run the source code in an appropriate C# development environment.

## Usage

Run the program, and observe how subscribers are notified of updates from the publisher, demonstrating the Observer pattern in action.



### Analysis and Code for Each Step

#### Step 1: Define Observer Interface

```csharp

internal interface IObserver
{
    void Update(ISubject subject, string message);
}
```

#### Step 2: Define Subject Interface

```csharp

internal interface ISubject
{
    string Name { get; }
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string message);
}
```

#### Step 3: Implement Concrete Subject

```csharp

internal class Publisher : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private readonly string _name;

    public Publisher(string name)
    {
        _name = name;
    }

    public string Name => _name;

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(this, message);
        }
    }
}
```

#### Step 4: Implement Concrete Observers

```csharp

internal class Subscriber : IObserver
{
    private readonly string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void Update(ISubject subject, string message)
    {
        Console.WriteLine($"'{message}' message received from {subject.Name} by {_name}.");
    }
}
```

#### Step 5: Demo Usage

```csharp


public class Program
{
    public static void Main()
    {
        var publisher = new Publisher("Message Hub");
        var subscriber1 = new Subscriber("First Subscriber");
        var subscriber2 = new Subscriber("Second Subscriber");
        var subscriber3 = new Subscriber("Third Subscriber");

        Console.WriteLine("Adding the first and the second subscribers to the publisher.");
        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);

        Console.WriteLine("Notifying subscribers.");
        publisher.Notify("Sequence initiated.");

        Console.WriteLine("Removing the first subscriber.");
        publisher.Unsubscribe(subscriber1);

        Console.WriteLine("Adding the third subscriber.");
        publisher.Subscribe(subscriber3);

        Console.WriteLine("Notifying subscribers.");
        publisher.Notify("Update received from the server.");

        Console.ReadKey();
    }
}
```

