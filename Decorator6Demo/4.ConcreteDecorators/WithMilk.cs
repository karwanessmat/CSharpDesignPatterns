using Decorator6Demo._1.Component;
using Decorator6Demo._3.Decorator;

namespace Decorator6Demo._4.ConcreteDecorators;

public class WithMilk(ICoffee coffee) : CoffeeDecorator(coffee)
{
    private readonly ICoffee _coffee = coffee;

    public override string Serve()
    {
        return $"{_coffee.Serve()} with Milk";
    }
}