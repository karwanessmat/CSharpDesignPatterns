using Decorator6Demo._1_Component_Interface;
using Decorator6Demo._2_Create_a_Concrete_Component;
using Decorator6Demo._4_Create_Concrete_Decorator;

ICoffee coffee = new Coffee();

// adding the two feature (decorated) to coffee
coffee = new WithMilk(coffee); // Decorate with Milk
coffee = new WithSugar(coffee); // Further decorate with Sugar

Console.WriteLine(coffee.Serve());
// Output: Coffee with Milk with Sugar