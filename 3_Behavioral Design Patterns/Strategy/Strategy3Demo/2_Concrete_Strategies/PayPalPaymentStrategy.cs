using Strategy3Demo._1_Define_Strategy_Interface;

namespace Strategy3Demo._2_Concrete_Strategies;

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public bool ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing ${amount} via PayPal.");
        return true; // Simulate payment processing
    }
}