# What is Creational?
> ## A creational design pattern in software development is a way of designing software to handle the creation of objects. These patterns help to make the system independent of how its objects are created, composed, and represented. Essentially, they provide blueprints for creating instances of classes, allowing for more flexible and reusable code. Creational patterns often make it easier to add new types of objects as your software grows and changes.
> ## A Creational patterns provide object creation mechanisms that increase flexibility and reuse of existing code. <br/>


 - **factory method**🏭: The factory method in design patterns is a way to create objects without specifying the exact class of object that will be created. It's like a factory that produces different types of products. Instead of building the product directly, you tell the factory what type of product you want, and it gives you the product. This method is useful because it allows your code to work with different types of objects without knowing their exact classes.<br/>

 - **factory method**🏭: “A factory is an object used for creating other objects. In technical terms, we can say that a factory is a class with a method. That method will create and return different objects based on the received input parameter“.<br/>

> In simple words, if we have a superclass and n number of subclasses, and based on the data provided, if we have to create and return the object of one of the subclasses, then we need to use the Factory Design Pattern in C#.
 ### Advantage
 1. Factory method enforces single responsibility principle.
 2. This allows us to easily maintain the code and write automted tests for it.
 3. Factory method allows us to execute a particular conditoin once.

  ### Disadvantage

  1. Might make your code more complicated if only a single factory method is used.