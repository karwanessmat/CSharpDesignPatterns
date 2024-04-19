using Decorator6Demo._1_Component_Interface;
using Decorator6Demo._3__Create_an_Abstract_Decorator;

namespace Decorator6Demo._4_Create_Concrete_Decorator;

public class WithMilk(ICoffee coffee) : CoffeeDecorator(coffee)
{
    private readonly ICoffee _coffee = coffee;

    public override string Serve()
    {
        return $"{_coffee.Serve()} with Milk";
    }
}