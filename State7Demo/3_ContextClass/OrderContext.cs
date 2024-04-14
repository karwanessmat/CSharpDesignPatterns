using State7Demo._1_CreateStateInterface;

namespace State7Demo._3_ContextClass;
// Context class
public class OrderContext
{
    private OrderState _state;

    public OrderContext(OrderState state)
    {
        TransitionTo(state);
    }

    public void TransitionTo(OrderState state)
    {
        Console.WriteLine($"Transitioning to {state.GetType().Name}");
        this._state = state;
        this._state.SetContext(this);
    }

    public void Pay()
    {
        this._state.Pay();
    }

    public void Ship()
    {
        this._state.Ship();
    }

    public void Deliver()
    {
        this._state.Deliver();
    }
}