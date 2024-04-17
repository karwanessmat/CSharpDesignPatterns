

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

    protected abstract void ExecutePayment(); // each subclass has its own logic


    protected virtual void InitializeTransaction() // each subclass can write its own logic
    {
        Console.WriteLine("Initializing transaction.");
    }


    protected virtual void FinalizeTransaction() // each subclass can write its own logic
    {
        Console.WriteLine("Finalizing transaction.");
        LogTransaction();
    }

    protected void LogTransaction()
    {
        Console.WriteLine("Logging transaction to system.");
    }
}