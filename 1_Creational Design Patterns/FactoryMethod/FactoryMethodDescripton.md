# Factory Method Design Pattern

The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created.

## Overview

1. **Product**: This interface is common to all objects that can be produced by the creator and its subclasses.
2. **Concrete Products**: These are different implementations of the product interface.
3. **Creator**: This class declares the factory method that returns new product objects. It's important that the return type of this method matches the product interface. The factory method can be declared as abstract to force all subclasses to implement their own versions of the method. Alternatively, the base factory method can return some default product type.
   - Note that product creation is not the primary responsibility of the creator. The creator class usually has some core business logic related to products. The factory method helps to decouple this logic from the concrete product classes.
4. **Concrete Creators**: These classes override the base factory method so it returns a different type of product.

## Pros and Cons

- **Pros**:
  - Avoids tight coupling between the creator and the concrete products.
  - Adheres to the Single Responsibility Principle by moving the product creation code into one place in the program, making the code easier to support.
  - Adheres to the Open/Closed Principle by allowing new types of products to be introduced into the program without breaking existing client code.

## Implementation Steps

Here is a simplified step-by-step guide to implementing the Factory Method pattern:

### Step 1: Define the Product Interface

```csharp
public interface ITransport
{
    void Deliver();
}
```

### Step 2: Create Concrete Products

```csharp
public class Air : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by air in a airplane.");
    }
}

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by sea in a ship.");
    }
}

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by land in a truck.");
    }
}
```

### Step 3: Declare the Creator Class

```csharp
public abstract class Logistics
{
    public abstract ITransport CreateTransport();
    
    public void PlanDelivery()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }
}
```

### Step 4: Implement Concrete Creator Classes

```csharp
public class AirLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Air();
    }
}

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
```

### Step 5: Use the Factory Method

```csharp
class Program
{
    static void Main()
    {
    Logistics logistics = new RoadLogistics();
    logistics.PlanDelivery();

    logistics = new AirLogistics();
    logistics.PlanDelivery();

    logistics = new SeaLogistics();
    logistics.PlanDelivery();
    }
}

```