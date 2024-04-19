using State7Demo._1_CreateStateInterface;

namespace State7Demo._2_ImplementConcreteStates;

public class PaidState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order is already paid.");
    }

    public override void Ship()
    {
        Console.WriteLine("Order has been shipped.");
        Order.TransitionTo(new ShippedState());
    }

    public override void Deliver()
    {
        Console.WriteLine("Order must be shipped before it can be delivered.");
    }
}