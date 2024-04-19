# Structural Design Patterns 🏗️

Structural design patterns are foundational templates that help organize objects and classes into larger, more complex structures while maintaining flexibility and efficiency. They provide a blueprint for integrating different parts of a program into a cohesive system.

## Overview 📄

These patterns ensure that if one part changes, the entire structure does not need to be altered, thereby making them essential for developing scalable and maintainable software.

---
---
---
### Adapter Pattern 🌉
- **Purpose**: Allows two incompatible interfaces to work together.
- **Use Case**: Connecting a new third-party library to your existing system.

---
---
---


### Bridge Pattern 🎭
- **Purpose**: Decouples an abstraction from its implementation so that the two can vary independently.
- **Use Case**: Supporting multiple types of database servers.

### Bridge Pattern Example: Database Server Abstraction

This example demonstrates the use of the Bridge design pattern to support multiple types of database servers in a C# application. The Bridge pattern helps decouple an abstraction from its implementation, allowing them to vary independently.

---

## 1. Understanding the Bridge Pattern

The Bridge pattern involves an abstraction (in this case, `Database`) and an implementation (represented by `IDatabaseImplementation`), with the abstraction forwarding client requests to the implementation. This allows the abstraction and implementation to vary independently.



## 2. Implementation Details
To implement the Bridge pattern in C# for the use case of supporting multiple types of database servers, we can create an abstraction for a generic Database and then implement specific databases like SQLServerDatabase, MySQLDatabase, etc. Here's how you can structure this in C#:
```csharp
// Abstraction Layer
//Create an abstract class Database that holds a reference to IDatabaseImplementation:
public abstract class Database
{
    protected IDatabaseImplementation _implementation;

    public Database(IDatabaseImplementation implementation)
    {
        _implementation = implementation;
    }

    public abstract void Connect();
    public abstract void ExecuteCommand(string command);
    public abstract void Close();
}

// Implementation Interface
public interface IDatabaseImplementation
{
    void OpenConnection();
    void RunCommand(string command);
    void CloseConnection();
}

// Concrete Implementations
//mplement this interface for each type of database server you want to support, for example, SQL Server and MySQL:
public class SQLServerImplementation : IDatabaseImplementation
{
    public void OpenConnection()
    {
        Console.WriteLine("Connecting to SQL Server...");
    }

    public void RunCommand(string command)
    {
        Console.WriteLine($"Executing SQL Server Command: {command}");
    }

    public void CloseConnection()
    {
        Console.WriteLine("Closing connection to SQL Server.");
    }
}

public class MySQLImplementation : IDatabaseImplementation
{
    public void OpenConnection()
    {
        Console.WriteLine("Connecting to MySQL...");
    }

    public void RunCommand(string command)
    {
        Console.WriteLine($"Executing MySQL Command: {command}");
    }

    public void CloseConnection()
    {
        Console.WriteLine("Closing connection to MySQL.");
    }
}

// Refined Abstractions
public class SQLServerDatabase : Database
{
    public SQLServerDatabase(IDatabaseImplementation implementation) : base(implementation)
    {
    }

    public override void Connect()
    {
        _implementation.OpenConnection();
    }

    public override void ExecuteCommand(string command)
    {
        _implementation.RunCommand(command);
    }

    public override void Close()
    {
        _implementation.CloseConnection();
    }
}

public class MySQLDatabase : Database
{
    public MySQLDatabase(IDatabaseImplementation implementation) : base(implementation)
    {
    }

    public override void Connect()
    {
        _implementation.OpenConnection();
    }

    public override void ExecuteCommand(string command)
    {
        _implementation.RunCommand(command);
    }

    public override void Close()
    {
        _implementation.CloseConnection();
    }
}

// Example Usage
class Program
{
    static void Main(string[] args)
    {
        var sqlServer = new SQLServerDatabase(new SQLServerImplementation());
        sqlServer.Connect();
        sqlServer.ExecuteCommand("SELECT * FROM Users");
        sqlServer.Close();

        var mySQL = new MySQLDatabase(new MySQLImplementation());
        mySQL.Connect();
        mySQL.ExecuteCommand("SELECT * FROM Products");
        mySQL.Close();
    }
}

```



---
---
---


















### Composite Pattern 🌳
- **Purpose**: Allows clients to treat individual objects and compositions of objects uniformly.
- **Use Case**: Graphic rendering engines, where different elements form a graphic tree.
---
---
---
### Decorator Pattern 🎁
- **Purpose**: Adds new functionalities to objects dynamically without altering their structure.
- **Use Case**: Adding new features to a UI component without modifying the original class.
---
---
---
### Facade Pattern 🚪
- **Purpose**: Provides a simplified interface to a complex subsystem.
- **Use Case**: Simplifying the interface of a complex media player.
---
---
---
### Flyweight Pattern 🪶
- **Purpose**: Reduces the cost of creating and manipulating a large number of similar objects.
- **Use Case**: Character models in a word processor or game.
---
---
---
### Proxy Pattern 🛡️
- **Purpose**: Provides a placeholder or surrogate for another object to control access to it.
---
---
---