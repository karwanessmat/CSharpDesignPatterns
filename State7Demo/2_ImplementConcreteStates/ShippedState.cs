using State7Demo._1_CreateStateInterface;

namespace State7Demo._2_ImplementConcreteStates;

public class ShippedState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order is already paid.");
    }

    public override void Ship()
    {
        Console.WriteLine("Order is already shipped.");
    }

    public override void Deliver()
    {
        Console.WriteLine("Order has been delivered.");
        Order.TransitionTo(new DeliveredState());
    }
}