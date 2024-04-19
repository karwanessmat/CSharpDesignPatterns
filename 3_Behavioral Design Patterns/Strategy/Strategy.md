# Strategy Pattern Example in C#

## Overview

The Strategy pattern is a behavioral design pattern that allows algorithms to be encapsulated within classes and made interchangeable within the object using them. This pattern is particularly useful when you have multiple algorithms for performing a task and you want to switch between them dynamically.

### Frequency of use: `5/5` high
## Description

The Strategy pattern involves three main components:
- **Strategy Interface:** This defines a common interface for all concrete strategies.
- **Concrete Strategies:** These classes implement the strategy interface and define the specific algorithm to be executed.
- **Context:** This class maintains a reference to a strategy object and delegates the task to the strategy.

## Implementation

The following C# example demonstrates the Strategy pattern with a simple navigation system that can switch routing strategies (car, walking, public transport) dynamically.

### Strategy Interface

Defines the interface for routing strategies.

```csharp
public interface IRouteStrategy
{
    string BuildRoute(string origin, string destination);
}
```

### Concrete Strategies

Implementations of different routing strategies.

```csharp
public class CarRouteStrategy : IRouteStrategy
{
    public string BuildRoute(string origin, string destination)
    {
        return $"Car route from {origin} to {destination}";
    }
}

public class WalkingRouteStrategy : IRouteStrategy
{
    public string BuildRoute(string origin, string destination)
    {
        return $"Walking route from {origin} to {destination}";
    }
}

public class PublicTransportStrategy : IRouteStrategy
{
    public string BuildRoute(string origin, string destination)
    {
        return $"Public transport route from {origin} to {destination}";
    }
}
```

### Context Class

The Navigator class that uses a strategy to calculate routes.

```csharp
public class Navigator
{
    private IRouteStrategy _routeStrategy;

    public Navigator(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }

    public void SetRouteStrategy(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }

    public string GetRoute(string origin, string destination)
    {
        return _routeStrategy.BuildRoute(origin, destination);
    }
}
```

### Usage Example

Demonstrates how to use the Navigator with different strategies.

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Initialize with a default strategy
        Navigator navigator = new Navigator(new CarRouteStrategy());

        // Get route using the initial strategy
        Console.WriteLine(navigator.GetRoute("Home", "Office"));

        // Change to a different strategy
        navigator.SetRouteStrategy(new WalkingRouteStrategy());
        Console.WriteLine(navigator.GetRoute("Home", "Park"));

        // Change to another strategy
        navigator.SetRouteStrategy(new PublicTransportStrategy());
        Console.WriteLine(navigator.GetRoute("Home", "Museum"));
    }
}
```

## Conclusion

The Strategy pattern provides a way to configure a class with one of many behaviors, allowing for dynamic changes in behavior at runtime without the need for complex conditionals. This simplifies code maintenance and enhances flexibility.