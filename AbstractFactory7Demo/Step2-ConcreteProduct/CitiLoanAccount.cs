using AbstractFactory6Demo.step1_AbstractProduct;

namespace AbstractFactory6Demo.Step2_ConcreteProduct;

public class CitiLoanAccount : ILoanAccount
{
    public CitiLoanAccount()
    {
            Console.WriteLine("Returned Citi Loan Account");
    }
}