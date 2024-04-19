using AbstractFactory6Demo.step1_AbstractProduct;

namespace AbstractFactory6Demo.Step2_ConcreteProduct;

public class NationalLoanAccount : ILoanAccount
{
    public NationalLoanAccount()
    {
        Console.WriteLine("Returned National Loans Account");
    }
}