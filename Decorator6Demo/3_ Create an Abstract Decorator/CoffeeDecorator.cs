using Decorator6Demo._1_Component_Interface;

namespace Decorator6Demo._3__Create_an_Abstract_Decorator;

// Create a 'Decorator' base class that also implements the 'Component' interface
public  class CoffeeDecorator(ICoffee coffee) : ICoffee
{

    public virtual string Serve()
    {
        return coffee.Serve();
    }
}