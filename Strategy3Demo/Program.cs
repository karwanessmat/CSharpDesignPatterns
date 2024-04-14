using Strategy3Demo._2_Concrete_Strategies;
using Strategy3Demo._3_ContextClass;

var pc =new PaymentContext(new CreditCardPaymentStrategy());
pc.ExecutePayment(200);

pc.SetPaymentStrategy(new PayPalPaymentStrategy());
pc.ExecutePayment(300);

pc.SetPaymentStrategy(new BankTransferPaymentStrategy());
pc.ExecutePayment(400);