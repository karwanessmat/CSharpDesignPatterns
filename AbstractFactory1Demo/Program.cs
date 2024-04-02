using AbstractFactory1Demo;
using AbstractFactory1Demo.Step4_Concrete_Factories;

// The Client (5) would request an object from the AbstractFactory (3).
//ConcreteFactory1 and ConcreteFactory2 implemented AbstractFactory 
var client1 = new Client(new ConcreteFactory1());
Console.WriteLine(client1.Operation());

var client2= new Client(new ConcreteFactory2());
Console.WriteLine(client2.Operation());