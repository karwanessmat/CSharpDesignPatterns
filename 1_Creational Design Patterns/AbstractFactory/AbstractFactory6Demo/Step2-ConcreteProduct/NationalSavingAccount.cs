using AbstractFactory6Demo.step1_AbstractProduct;

namespace AbstractFactory6Demo.Step2_ConcreteProduct;

public class NationalSavingAccount : ISavingAccount
{
    public NationalSavingAccount()
    {
        Console.WriteLine("Returned National Savings Account");
    }

}