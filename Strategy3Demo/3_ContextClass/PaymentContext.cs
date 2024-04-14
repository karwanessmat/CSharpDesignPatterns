using Strategy3Demo._1_Define_Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
