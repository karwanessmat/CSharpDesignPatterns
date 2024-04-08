# Computer System Facade Pattern Implementation 🖥️

## Overview 📜

The Facade Pattern is a structural design pattern that provides a simplified interface to a complex subsystem, making it easier to use. This repository contains an implementation of the Facade Pattern in the context of a computer system. The facade simplifies the operations required to start and shut down a computer by hiding the complexities of the individual components, such as the CPU, memory, and hard drive.

## Features 🌟

- **Simplified Interface**: Offers an easy-to-use interface to perform common operations on the computer system.
- **Encapsulation of Complexities**: Hides the detailed operations of starting and shutting down the computer, making the client code cleaner and more maintainable.
- **Extensibility**: New operations or components can be added to the system without affecting the facade's client code.

## Components 🛠️

1. **CPU (Central Processing Unit)**: Manages the booting up and shutting down processes.
2. **Memory**: Handles the loading of data into the system's memory.
3. **Hard Drive**: Responsible for reading data from storage.

## Interface 📑

The `IComputerFacade` interface defines the basic operations that can be performed on the computer system:

- `Start()`: Starts the computer.
- `ShutDown()`: Shuts down the computer.

## Implementation 🚀

### Subsystem Classes

- `CPU`: Simulates the central processing unit of the computer.
- `Memory`: Represents the memory component of the computer.
- `Hard Drive`: Simulates the hard drive operations.

### Facade Class

- `ComputerFacade`: Implements the `IComputerFacade` interface and orchestrates the actions between the subsystems to start and shut down the computer.

## Usage Example 📖

```csharp
IComputerFacade computer = new ComputerFacade();

// Start the computer
computer.Start();

// Now the computer is ready to use...

// Shut down the computer
computer.ShutDown();
```

## Conclusion 📌

The Facade Pattern in this implementation abstracts the complexities of the computer system's operations, providing a straightforward and easy-to-use interface. This approach not only simplifies the client's interaction with the system but also enhances the maintainability and extensibility of the codebase.


