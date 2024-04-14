using Strategy3Demo._1_Define_Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy3Demo._2_Concrete_Strategies;

public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public bool ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing ${amount} via Credit Card.");
        return true; // Simulate payment processing
    }
}