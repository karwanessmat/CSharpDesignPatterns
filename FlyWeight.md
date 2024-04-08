
 

# `use:` `1/5` `Low`

# Flyweight Design Pattern

## Overview

The Flyweight design pattern is a structural pattern designed to reduce memory usage and enhance performance by efficiently sharing common parts of an object's state among multiple instances. This approach is beneficial in environments where a vast number of objects are created, and each object's memory footprint is significant. The Flyweight pattern minimizes resource consumption by reusing object instances, thereby increasing efficiency, especially in scenarios where similar objects are instantiated multiple times.

## Definition

The Flyweight pattern facilitates the sharing of state among a multitude of fine-grained objects, thereby improving memory efficiency. It achieves this by segregating the object's state into two categories:

- **Intrinsic State**: The immutable shared state common across multiple objects, stored in the flyweight.
- **Extrinsic State**: The mutable state that varies between objects and is not shared, passed to the flyweight when required.

## Implementation Steps

### 1. Identify Shareable State

Determine the common, unchanging properties across your objects. This shareable component is the intrinsic state.

### 2. Create the Flyweight Interface

Develop a `Flyweight` interface that outlines methods for interacting with the extrinsic state.

```csharp
public interface IFlyweight {
    void Operation(string extrinsicState);
}
```

### 3. Implement ConcreteFlyweight Classes

Construct one or more classes implementing the `Flyweight` interface to manage the intrinsic state.

```csharp
public class ConcreteFlyweight : IFlyweight {
    private readonly string _intrinsicState;

    public ConcreteFlyweight(string intrinsicState) {
        _intrinsicState = intrinsicState;
    }

    public void Operation(string extrinsicState) {
        Console.WriteLine($"Intrinsic State: {_intrinsicState}, Extrinsic State: {extrinsicState}");
    }
}
```

### 4. Implement the Flyweight Factory

The factory's role is to create and oversee the flyweight objects, ensuring their effective sharing.

```csharp
public class FlyweightFactory {
    private readonly Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

    public IFlyweight GetFlyweight(string key) {
        if (!_flyweights.ContainsKey(key)) {
            _flyweights[key] = new ConcreteFlyweight(key);
        }
        return _flyweights[key];
    }
}
```

### 5. Implement Client

The client holds references to flyweights and handles the extrinsic state, utilizing the factory to access flyweight instances.

```csharp
public class Client {
    private readonly FlyweightFactory _factory;

    public Client(FlyweightFactory factory) {
        _factory = factory;
    }

    public void Run() {
        var flyweight = _factory.GetFlyweight("sharedState");
        flyweight.Operation("uniqueState");
    }
}
```

### 6. Usage

The client engages the factory to coordinate flyweights, inputting the extrinsic state during operations.

```csharp
var factory = new FlyweightFactory();
var client = new Client(factory);
client.Run();
```

## Pros and Cons

**Pros:**
- Reduces memory and resource usage by minimizing the number of object instances.
- Improves performance by reusing existing similar kind objects.
- Efficient in scenarios requiring a large number of almost similar object instances.

**Cons:**
- Increases code complexity.
- Object state management becomes more challenging, necessitating careful differentiation between shareable and non-shareable states.

## Applicability

- Ideal when your application needs to manage a large number of objects, and memory savings are a priority.
- Beneficial where many objects can share common state, reducing the overall memory footprint.
- Suitable when most of the object's state can be computed or stored externally to minimize in-memory state.

## Conclusion

The Flyweight design pattern is crucial for optimizing memory usage in systems with numerous similar objects. By smartly extracting and managing shared state, it allows for scalable and efficient system performance.