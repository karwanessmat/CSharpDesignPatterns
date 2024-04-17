
# CSharpDesignPatterns

Welcome to the CSharpDesignPatterns repository! This project is designed to help developers learn and understand various design patterns in C# through practical examples. Each example demonstrates how design patterns can solve common software design problems.

## Creational Design Patterns 🏗️

Creational patterns are all about class instantiation or object creation. These patterns are crucial for creating objects in a system more efficiently.

### 🌟 Singleton [#1]

Ensures that a class has only one instance and provides a global point of access to it.

**Use Case**: Managing a database connection or application settings.

---

### 🏭 Factory Method [#2]

Defines an interface for creating an object, but lets subclasses decide which class to instantiate.

**Use Case**: In a UI library, where different types of elements are created based on user input.

---

### 🎨 Abstract Factory [#3]

Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

**Use Case**: Cross-platform UI elements that look native on different operating systems.

---

### 🛠️ Builder [#4]

Allows constructing complex objects step by step.

**Use Case**: Building complex, configurable objects like cars, where each car can have different features and configurations.

---

### 📋 Prototype [#5]

Enables copying existing objects without making the code dependent on their classes.

**Use Case**: Duplication of complex objects like graphs or trees where each node might have numerous attributes or configurations.

### ------------------------------------------------------------------------------------------------------

## Structural Design Patterns 🏛️

Structural patterns help to compose groups of objects into larger structures, like building parts into a large structure.

### 🌉 Adapter [#6]

Allows two incompatible interfaces to work together.

**Use Case**: Connecting a new third-party library to your existing system.

---

### 🎭 Bridge [#7]

Decouples an abstraction from its implementation so that the two can vary independently.

**Use Case**: Supporting multiple types of database servers.

---

### 🌳 Composite [#8]

Describes a group of objects that is treated the same way as a single instance of the same type of object.

**Use Case**: Graphic rendering engines, where different elements form a graphic tree.

---

### 🎁 Decorator [#9]

Adds responsibilities to objects dynamically without altering their structure.

**Use Case**: Adding new features to a UI component without modifying the original class.

---

### 🚪 Facade [#10]

Provides a simplified interface to a complex subsystem.

**Use Case**: Simplifying the interface of a complex media player.

---

### 🪶 Flyweight [#11]

Reduces the cost of creating and manipulating a large number of similar objects.

**Use Case**: Character models in a word processor or game.

---

### 🛡️ Proxy [#12]

Provides a placeholder or surrogate for another object to control access to it.

**Use Case**: Managing access to resource-heavy objects.

### ------------------------------------------------------------------------------------------------------

## Behavioral Design Patterns 🔄

Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects.

### 🔗 Chain of Responsibility [#13]

Passes a request along a chain of handlers, where each handler can process the request or forward it to the next handler.

**Use Case**: Processing different types of document approvals in an organizational workflow.

---

### 📊 Strategy [#14]

Enables the selection of an algorithm's behavior at runtime.

**Use Case**: Changing the sorting behavior of a list based on user preferences.

---

### 👀 Observer [#15]

Establishes a one-to-many relationship between objects.

**Use Case**: Updating multiple display elements when data in a sensor system changes.

---

### 🔄 State [#16]

Allows an object to alter its behavior when its internal state changes.

**Use Case**: Changing the modes of a user interface based on user interactions.

---

### 📝 Template Method [#17]

Outlines the program skeleton in a method, deferring certain steps to subclasses.

**Use Case**: Defining the structure of a data processing algorithm while allowing subclasses to provide detailed implementation.

---

### 🖱️ Command [#18]

Encapsulates a request as an object, thereby allowing for parameterization and queuing of requests.

**Use Case**: Implementing redo-undo functionality in a text editor.

---

### 🚶 Visitor [#19]

Permits operations to be applied on a set of objects at runtime, separating operations from the object structure.

**Use Case**: Applying different operations on a set of documents depending on their type.

### ------------------------------------------------------------------------------------------------------

## Contributing

Feel free to fork this project and submit pull requests. You can also open issues if you find any bugs or have any feature requests.

## Connect with Me

- **GitHub**: [@karwanessmat](https://github.com/karwanessmat)
- **LinkedIn**: [Karwan Essmat Othman](https://www.linkedin.com/in/karwan-othman/)

## Appreciation

Thank you to all contributors who have invested their time in contributing to this project. Your valuable contributions help improve and expand this learning resource.

**Enjoy learning and building with CSharpDesignPatterns!**
