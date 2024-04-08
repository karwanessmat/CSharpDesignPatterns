using Decorator6Demo._1.Component;

namespace Decorator6Demo._3.Decorator;

// Create a 'Decorator' base class that also implements the 'Component' interface
public  class CoffeeDecorator(ICoffee coffee) : ICoffee
{

    public virtual string Serve()
    {
        return coffee.Serve();
    }
}