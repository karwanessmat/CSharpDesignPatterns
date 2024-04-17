using State7Demo._1_CreateStateInterface;

namespace State7Demo._2_ImplementConcreteStates;
// Concrete State classes
public class OrderedState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order has been paid.");
        Order.TransitionTo(new PaidState());
    }

    public override void Ship()
    {
        Console.WriteLine("Order must be paid before it can be shipped.");
    }

    public override void Deliver()
    {
        Console.WriteLine("Order must be shipped before it can be delivered.");
    }
}