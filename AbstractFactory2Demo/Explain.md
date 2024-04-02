# Abstract Factory Pattern in C#

## Overview
The Abstract Factory Pattern is a creational design pattern that enables the creation of families of related objects without having to depend on their concrete classes. This is helpful for ensuring that the created objects can work together without needing to know the specifics of how they're created or what their exact types are.

## Project Structure

The project follows the Abstract Factory pattern's structure and includes the following components:

- **Interfaces (`IChair`, `ISofa`)**: Define the abstract product interfaces for the furniture items.
- **Concrete Products (`ModernChair`, `VictorianChair`)**: Implement the abstract product interfaces to create distinct product variants.
- **Abstract Factory Interface (`IFurnitureFactory`)**: An interface to create abstract product families.
- **Concrete Factories (`ModernFurnitureFactory`, `VictorianFurnitureFactory`)**: Implement the Abstract Factory interface to create concrete products.
- **Client (`FurnitureStore`)**: Uses the abstract factory and product interfaces to operate on the abstract products produced by the concrete factories.

## Implementation

### Abstract Products

We define interfaces for each type of product in our product family. Here's how we define the furniture products:

```csharp
// Step 1: Define Abstract Products - Furniture items like Chair and Sofa.
public interface IChair
{
    void SitOn();
}

public interface ISofa
{
    void RelaxOn();
}

// Step 2: Create Concrete Products - Modern and Victorian variants of the furniture.
public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair.");
    }
}

public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}

public class ModernSofa : ISofa
{
    public void RelaxOn()
    {
        Console.WriteLine("Relaxing on a modern sofa.");
    }
}

public class VictorianSofa : ISofa
{
    public void RelaxOn()
    {
        Console.WriteLine("Relaxing on a Victorian sofa.");
    }
}

// Step 3: Declare the Abstract Factory Interface.
public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
}

// Step 4: Implement Concrete Factories for each style.
public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
}

// Step 5: Client code that uses Abstract Factory to create furniture.
public class FurnitureStore
{
    private IFurnitureFactory _furnitureFactory;

    public FurnitureStore(IFurnitureFactory furnitureFactory)
    {
        _furnitureFactory = furnitureFactory;
    }

    public void ShowCaseFurniture()
    {
        var chair = _furnitureFactory.CreateChair();
        var sofa = _furnitureFactory.CreateSofa();

        chair.SitOn();
        sofa.RelaxOn();
    }
}

// Application entry point
class Program
{
    static void Main(string[] args)
    {
        IFurnitureFactory furnitureFactory = new ModernFurnitureFactory();
        FurnitureStore store = new FurnitureStore(furnitureFactory);
        store.ShowCaseFurniture();

        // Switch to a different furniture style easily
        furnitureFactory = new VictorianFurnitureFactory();
        store = new FurnitureStore(furnitureFactory);
        store.ShowCaseFurniture();
    }
}
```