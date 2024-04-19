using Template5Demo.AbstractClass;

namespace Template5Demo.ConcreteClass;

public class CreditCardProcessor : PaymentProcessor
{
    protected override void ExecutePayment()
    {
        Console.WriteLine("Processing credit card payment.");
        // Additional credit card specific logic here, e.g., contacting credit card gateway.
    }

    protected override void FinalizeTransaction()
    {
        base.FinalizeTransaction();
        SendPaymentConfirmationEmail();
    }

    private void SendPaymentConfirmationEmail()
    {
        Console.WriteLine("Sending payment confirmation email to customer.");
    }
}