# Car Manufacturing Simulation

This project demonstrates the Builder design pattern through a simulation of a car manufacturing process. The goal is to construct different types of cars and their corresponding user manuals through a series of predefined steps.

## Contents

- `Car.cs` - Defines the `Car` class with properties such as seats, engine, GPS, etc.
- `Engine.cs` - Defines the `Engine` class which is a property of `Car`.
- `Manual.cs` - Defines the `Manual` class with instructions corresponding to the `Car` features.
- `IBuilder.cs` - Defines the builder interface with methods to assemble parts of the product.
- `CarBuilder.cs` - Implements the `IBuilder` interface to create a `Car` object.
- `CarManualBuilder.cs` - Implements the `IBuilder` interface to create a `Manual` object.
- `CarDirector.cs` - Orchestrates the construction of `Car` objects through `CarBuilder`.
- `CarManualDirector.cs` - Orchestrates the construction of `Manual` objects through `CarManualBuilder`.
- `Application.cs` - Contains the `Application` class that uses the Director classes to create products.
- `Program.cs` - The entry point of the application which demonstrates the construction process.

## Steps of Execution

1. **Define the Product Classes**: `Car`, `Engine`, and `Manual` classes are defined to represent the complex objects that will be created.

2. **Create the Builder Interface**: `IBuilder` is the interface that defines the steps to build parts of the product.

3. **Implement the Builders**: `CarBuilder` and `CarManualBuilder` implement the `IBuilder` interface to handle the construction process of `Car` and `Manual`, respectively.

4. **Define the Directors**: `CarDirector` and `CarManualDirector` are defined to execute the building steps in a particular sequence.

5. **Create the Application Class**: The `Application` class utilizes the Director classes to construct the products.

6. **Run the Simulation**: The `Program` class invokes the `Application` to create different types of cars and manuals.

## How to Run

To execute the simulation, compile and run the `Program.cs` file which will initiate the creation process and output the results to the console.

## Conclusion

This project illustrates the utility of the Builder pattern in scenarios where a complex object is constructed step by step. By encapsulating the construction logic within specific Director classes, we can produce variations of the product with the same construction process.

