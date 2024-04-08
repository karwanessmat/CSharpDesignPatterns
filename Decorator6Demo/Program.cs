

using Decorator6Demo._1.Component;
using Decorator6Demo._2.ConcreteComponents;
using Decorator6Demo._4.ConcreteDecorators;

ICoffee coffee = new Coffee();
coffee = new WithMilk(coffee); // Decorate with Milk
coffee = new WithSugar(coffee); // Further decorate with Sugar

Console.WriteLine(coffee.Serve());
// Output: Coffee with Milk with Sugar