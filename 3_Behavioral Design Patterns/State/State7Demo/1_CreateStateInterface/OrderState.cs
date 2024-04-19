using State7Demo._3_ContextClass;

namespace State7Demo._1_CreateStateInterface;
public abstract class OrderState
{
    protected OrderContext Order = null!;

    public void SetContext(OrderContext order)
    {
        this.Order = order;
    }

    public abstract void Pay();
    public abstract void Ship();
    public abstract void Deliver();
}