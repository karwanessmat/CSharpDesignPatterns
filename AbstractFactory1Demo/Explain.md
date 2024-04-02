# C# Abstract Factory Pattern Implementation

This repository contains a C# implementation of the Abstract Factory design pattern. The Abstract Factory is a creational pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.

## Pattern Overview

The Abstract Factory pattern is structured as follows:

- **Abstract Products (`ProductA` and `ProductB`)**: These are interfaces for a set of related objects, or a product family.
- **Concrete Products (`ConcreteProductA1`, `ConcreteProductA2`, `ConcreteProductB1`, and `ConcreteProductB2`)**: Classes that implement these abstract product interfaces, representing different products to be created.
- **Abstract Factory (`AbstractFactory`)**: An interface with a set of methods for creating each of the abstract products.
- **Concrete Factories (`ConcreteFactory1` and `ConcreteFactory2`)**: Classes that implement the AbstractFactory's creation methods to instantiate concrete products.
- **Client**: The part of the system that uses the factories to create products. It works with factories via the abstract interface but the actual created products are the concrete instances.

The interaction between these components typically follows this order:

1. The `Client` requests a product from the `AbstractFactory`.
2. The ConcreteFactory creates the actual product object.
3. The Client works with the created products via their abstract interface.

```csharp

// Abstract Product - step 1
public interface IProductA
{
    string FunctionA();
}

public interface IProductB
{
    string FunctionB();
}

// Concrete Products - step 2
public class ConcreteProductA1 : IProductA
{
    public string FunctionA()
    {
        return "Result of ConcreteProductA1";
    }
}

public class ConcreteProductA2 : IProductA
{
    public string FunctionA()
    {
        return "Result of ConcreteProductA2";
    }
}

public class ConcreteProductB1 : IProductB
{
    public string FunctionB()
    {
        return "Result of ConcreteProductB1";
    }
}

public class ConcreteProductB2 : IProductB
{
    public string FunctionB()
    {
        return "Result of ConcreteProductB2";
    }
}

// Abstract Factory - step 3
public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}

// Concrete Factories - step 4
public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

// Client Code - step 5
public class Client
{
    private readonly IProductA _productA;
    private readonly IProductB _productB;

    // Constructor requires an abstract factory, demonstrating Dependency Injection.
    public Client(IAbstractFactory factory)
    {
        // The client works with product interfaces only.
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void Run()
    {
        // Example operation that uses the abstract products.
        Console.WriteLine(_productA.FunctionA());
        Console.WriteLine(_productB.FunctionB());
    }
}

// Usage
public static class Program
{
    public static void Main()
    {
        // The client code can be configured with any concrete factory.
        Client client1 = new Client(new ConcreteFactory1());
        client1.Run();

        // Changing the factory changes the behavior of the client code.
        Client client2 = new Client(new ConcreteFactory2());
        client2.Run();
    }
}


```