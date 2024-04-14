using State7Demo._1_CreateStateInterface;

namespace State7Demo._2_ImplementConcreteStates;

public class DeliveredState : OrderState
{
    public override void Pay()
    {
        Console.WriteLine("Order is already paid and delivered.");
    }

    public override void Ship()
    {
        Console.WriteLine("Order is already delivered.");
    }

    public override void Deliver()
    {
        Console.WriteLine("Order is already delivered.");
    }
}