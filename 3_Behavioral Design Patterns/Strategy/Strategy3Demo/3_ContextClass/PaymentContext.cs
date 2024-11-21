using Strategy3Demo._1_Define_Strategy_Interface;

namespace Strategy3Demo._3_ContextClass;
public class PaymentContext(IPaymentStrategy strategy)
{
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        strategy = paymentStrategy;
    }

    public bool ExecutePayment(double amount)
    {
        return strategy.ProcessPayment(amount);
    }
}
