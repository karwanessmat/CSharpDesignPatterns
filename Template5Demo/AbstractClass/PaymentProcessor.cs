

namespace Template5Demo.AbstractClass;

public abstract class PaymentProcessor
{
    // The template method
    public void ProcessPayment()
    {
        InitializeTransaction();
        ExecutePayment();
        FinalizeTransaction();
    }

    protected virtual void InitializeTransaction()
    {
        Console.WriteLine("Initializing transaction.");
    }

    protected abstract void ExecutePayment();

    protected virtual void FinalizeTransaction()
    {
        Console.WriteLine("Finalizing transaction.");
        LogTransaction();
    }

    protected void LogTransaction()
    {
        Console.WriteLine("Logging transaction to system.");
    }
}