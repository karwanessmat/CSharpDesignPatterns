# Abstract Factory Pattern Demo

This project demonstrates the Abstract Factory design pattern, which allows for the creation of families of related or dependent objects without specifying their concrete classes. The pattern is structured in a series of namespaces and steps, each encapsulating a specific aspect of the Abstract Factory implementation.

## Overview

The demo simulates a computer assembly scenario where different types of computers (laptops and desktops) with various specifications (brand and processor) are created based on the requirements.

## Structure

The implementation is divided into the following namespaces and steps:

1. **Enums**
   - Defines the basic elements used to create computer objects such as `Brands`, `ComputerTypes`, and `Processors`.

2. **Step 1: Abstract Product**
   - Contains interfaces that define the methods to be implemented by the concrete products (`IBrand`, `IComputerType`, `IProcessor`).

3. **Step 2: Concrete Products**
   - Implements the abstract product interfaces for different computer specifications like `Apple`, `Dell`, `MSI` (for brands) and `i3`, `i5`, `i7`, `i9` (for processors).

4. **Step 3: Abstract Factory**
   - Defines an interface (`IComputerFactory`) for creating families of related or dependent objects.

5. **Step 4: Concrete Factories**
   - Contains concrete factories (`AppleDesktopFactory`, `AppleLaptopFactory`, `DellDesktopFactory`, `DellLaptopFactory`) that implement the abstract factory interface to create specific product families.
   - Includes `EmployeeSystemFactory` for selecting the appropriate factory based on the employee's ID and role.

6. **Step 5: Client**
   - Uses the abstract factory and concrete factories to demonstrate the creation of different computer systems based on the factory type.

7. **Main Program**
   - Entry point of the application where the abstract factory pattern is put into action to create computer systems based on predefined criteria.

## Usage

To run the demo, compile and execute the `Program` class. The output will demonstrate the creation of computer systems based on different factory selections, showcasing how the Abstract Factory pattern can be used to manage complex object creation scenarios in a scalable and extendable manner.

## Conclusion

This project provides a clear example of the Abstract Factory pattern in action, using a practical scenario of computer assembly. It illustrates how the pattern can help in organizing and managing the creation of complex object families while keeping the system flexible and maintainable.
