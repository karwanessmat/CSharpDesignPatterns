using Template5Demo.AbstractClass;
using Template5Demo.ConcreteClass;

Console.WriteLine("Processing credit card payment:");
PaymentProcessor paymentProcessor = new CreditCardProcessor();
paymentProcessor.ProcessPayment();

Console.WriteLine("\nProcessing PayPal payment:");
paymentProcessor = new PayPalProcessor();
paymentProcessor.ProcessPayment();

Console.WriteLine("\nProcessing bank transfer:");
paymentProcessor = new BankTransferProcessor();
paymentProcessor.ProcessPayment();