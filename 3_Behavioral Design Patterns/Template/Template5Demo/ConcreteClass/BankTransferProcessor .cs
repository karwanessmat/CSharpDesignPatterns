using Template5Demo.AbstractClass;

namespace Template5Demo.ConcreteClass;

public class BankTransferProcessor : PaymentProcessor
{
    protected override void ExecutePayment()
    {
        Console.WriteLine("Processing bank transfer.");
        // Additional bank transfer specific logic here, e.g., communicating with bank's API.
    }
}
