using ChainOfResponsibility5Demo.Step1_Interface;

namespace ChainOfResponsibility5Demo.step2_Concrete_Handlers;

public class PaymentsProcessor:Handler
{
    public override bool ExecutedTask(DomainRequest request)
    {
        Console.WriteLine("Processing payment");
        bool response = request.CreditCardInfo == "12345";
        if (response)
        {
            Console.WriteLine("We verified Credit card");
            Console.WriteLine("_________");
        }
        return response;
    }
}