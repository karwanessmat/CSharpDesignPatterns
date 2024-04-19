using Template5Demo.AbstractClass;

namespace Template5Demo.ConcreteClass;

public class PayPalProcessor : PaymentProcessor
{
    protected override void ExecutePayment()
    {
        Console.WriteLine("Processing payment through PayPal.");
        // Additional PayPal specific logic here, e.g., API integration.
    }
}