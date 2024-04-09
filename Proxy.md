surrogate: جێ گرتنه‌وه‌
Frequency of use: 4/5

Here's a detailed README.md content for the Proxy design pattern:

---

# Proxy Design Pattern

## Overview

The Proxy design pattern is a structural pattern that provides an object representing another object. This surrogate object controls access to the original object, allowing it to perform operations before or after forwarding the request to the original object. Proxies are useful for implementing lazy initialization, access control, logging, monitoring, locking, and other maintenance tasks that are needed when dealing with complex or resource-intensive objects.

Frequency of Use: 4/5

## Intent

- To provide a placeholder for another object to control access to it.
- To reduce the cost of expensive object creation until it is necessary.
- To add a layer of protection to the actual object from the outside world.

## Structure

The Proxy design pattern typically involves the following components:

1. **Subject**: An interface common to both the RealSubject and the Proxy, defining the common operations that the RealSubject performs.
2. **RealSubject**: The actual object that the Proxy represents.
3. **Proxy**: An object that controls access to the RealSubject, implementing the same interface as the RealSubject.

## Types of Proxies

- **Virtual Proxy**: Delays the creation and initialization of expensive objects until needed.
- **Protective Proxy**: Controls access to the RealSubject, providing security or other access control mechanisms.
- **Remote Proxy**: Represents an object that resides in a different address space (like a network server).
- **Smart Proxy**: Adds additional behavior to object access (e.g., reference counting, loading, or locking).

## Implementation

1. Define the `Subject` interface.
2. Implement the `RealSubject` class that contains the real operations.
3. Create a `Proxy` class that also implements the `Subject` interface.
4. The `Proxy` class contains a reference to a `RealSubject` object and controls access to this object.

## Advantages

- **Separation of Concerns**: The proxy can handle non-core responsibilities like access control, caching, or lazy instantiation, keeping the real subject's implementation clean and focused on its core responsibilities.
- **Enhanced Security**: Protects the real subject by providing a robust layer of security before delegating the requests to the subject.
- **Performance Optimization**: Can significantly improve the performance of an application through lazy initialization and caching mechanisms.

## Disadvantages

- **Complexity**: Introduces additional classes and objects, which can complicate the codebase.
- **Response Time**: The additional layer of abstraction can sometimes increase response time for operations.

## Example in C#

```csharp
public interface ISubject
{
    void Request();
}

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}

public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        if (_realSubject == null)
        {
            Console.WriteLine("Proxy: Initializing RealSubject.");
            _realSubject = new RealSubject();
        }

        Console.WriteLine("Proxy: Forwarding request to RealSubject.");
        _realSubject.Request();
    }
}

class Client
{
    public static void Main()
    {
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}
```

## Conclusion

The Proxy design pattern is essential for scenarios where an object needs a representative or placeholder to control access to it. With a usage frequency of 4 out of 5, it is a commonly used pattern, particularly in situations requiring an extra layer of abstraction for access control, lazy initialization, or other intermediatory operations.