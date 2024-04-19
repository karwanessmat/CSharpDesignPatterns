## what is Mediator
### a person or organization that tries to end a quarrel between two people, groups, countries etc by discussion  →  intermediary 
 
 
### Summary:  Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects  from referring  to each other explicitly, and it lets you vary their interaction independently.


### Frequency of use: 3/ 5 Medium low


 # Mediator Design Pattern README.md

## 📘 Introduction
The Mediator Design Pattern is used to reduce complex communication among related objects by centralizing communication to a mediator object. It helps in reducing the coupling between classes by providing a central place where interactions can be managed and mediated.

## 🚀 How to Implement the Mediator Pattern

### `we using 03_DefineComponentBaseClass because we do not want to have coupling of members to concrete componnets`

### Step 1: Define the Mediator Interface
Create an interface that defines the communication protocol for the mediator.

```csharp
public interface IMediator
{
    void Send(string message, Colleague colleague);
}
```

### Step 2: Create Concrete Mediator
Implement the mediator interface in a concrete mediator class. This class coordinates the communication between colleague objects.

```csharp
public class ConcreteMediator : IMediator
{
    public Colleague1 Colleague1 { get; set; }
    public Colleague2 Colleague2 { get; set; }

    public void Send(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
        {
            Colleague2.Notify(message);
        }
        else
        {
            Colleague1.Notify(message);
        }
    }
}
```

### Step 3: Define the Colleague Classes
These are the classes that will communicate with each other through the mediator. Each colleague class must have a reference to the mediator.

```csharp
public abstract class Colleague
{
    protected IMediator mediator;

    public Colleague(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Notify(string message);
}

public class Colleague1 : Colleague
{
    public Colleague1(IMediator mediator) : base(mediator) { }

    public override void Send(string message)
    {
        mediator.Send(message, this);
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Colleague1 gets message: {message}");
    }
}

public class Colleague2 : Colleague
{
    public Colleague2(IMediator mediator) : base(mediator) { }

    public override void Send(string message)
    {
        mediator.Send(message, this);
    }

    public override void Notify(string message)
    {
        Console.WriteLine($"Colleague2 gets message: {message}");
    }
}
```

### Step 4: Use the Mediator
Instantiate the mediator and colleague objects, and start communication between them through the mediator.

```csharp
var mediator = new ConcreteMediator();
var colleague1 = new Colleague1(mediator);
var colleague2 = new Colleague2(mediator);

mediator.Colleague1 = colleague1;
mediator.Colleague2 = colleague2;

colleague1.Send("Hello, World!");
colleague2.Send("Hello back!");
```

## 🌟 Conclusion
The Mediator Pattern helps in decoupling the communication between objects, making it easier to manage, extend, and maintain. By centralizing the communication, changes in the communication logic are made only in the mediator, improving the flexibility and scalability of the application.

---

This README.md provides a step-by-step guide to implementing the Mediator Design Pattern in C#. It's a simple and effective way to manage complex communications in your software design.