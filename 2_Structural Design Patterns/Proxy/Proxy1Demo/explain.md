# Proxy is a structural design pattern that provides an object that acts as a substitute 
for a real service object used by a client. A proxy receives client requests, does some work 
(access control, caching, etc.) and then passes the request to a service object.

surrogate: جێ گرتنه‌وه‌

Frequency of use: 4/5



# Proxy Design Pattern Implementation in C#

## Overview

The Proxy design pattern provides a surrogate or placeholder for another object to control access to it. This implementation demonstrates the use of the Proxy pattern in a simple C# application, where a proxy class controls access to a real subject class by implementing the same interface.

## Structure

The project is structured as follows:

- `ISubject`: An interface representing both the real and proxy objects.
- `RealSubject`: The actual object that performs the real operations.
- `Proxy`: A class that controls access to the `RealSubject`.
- `Client`: The main entry point of the application that uses the `Proxy`.

## Implementation

### 1. ISubject Interface

Defines a common interface for `RealSubject` and `Proxy`, ensuring interchangeability.

```csharp
public interface ISubject
{
    void Request();
}
```

### 2. RealSubject Class

Implements the `ISubject` interface and represents the actual object that the proxy controls access to.

```csharp
public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}
```

### 3. Proxy Class

Also implements the `ISubject` interface and controls access to the `RealSubject`. It can perform additional tasks, such as lazy initialization, access control, and logging.

```csharp
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
```

### 4. Client

The entry point of the application, which uses the `Proxy` to interact with the `RealSubject`.

```csharp
public class Client
{
    public void Main()
    {
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}
```

## Usage

To use this implementation:

1. Compile the C# files in your development environment.
2. Run the `Client` class. This will initiate a request through the `Proxy`, which in turn will manage the request to the `RealSubject`.

## Conclusion

The Proxy design pattern is particularly useful in situations where an object needs to be controlled or extended in some manner. This simple C# implementation demonstrates the core concept of the Proxy pattern, showcasing how control over object access can be managed and extended.