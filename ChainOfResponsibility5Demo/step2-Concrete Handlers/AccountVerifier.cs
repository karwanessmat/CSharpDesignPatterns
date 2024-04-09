using ChainOfResponsibility5Demo.Step1_Interface;

namespace ChainOfResponsibility5Demo.step2_Concrete_Handlers;

public class AccountVerifier:Handler
{
    public override bool ExecutedTask(DomainRequest request)
    {
        Console.WriteLine("Verifying account");
        var isValid = request is { UserName: "demo", Password: "123" };
        return isValid;
    }
}