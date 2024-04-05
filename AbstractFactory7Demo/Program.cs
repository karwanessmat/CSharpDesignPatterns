
using AbstractFactory6Demo.step1_AbstractProduct;
using AbstractFactory6Demo.Step3_Abstract_Factories;
using AbstractFactory6Demo.Step5_Client;

var accountNumbers = new List<string>()
{
    "CITI-432",
    "NATIONAL-987",
    "CHASE-222"
};


foreach (var t in accountNumbers)
{
    CreditUnionFactory abAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(t);
    if (abAbstractFactory is null)
    {
        Console.WriteLine($"Sorry this credit union w/ account number {t} is invalid.");
    }
    else
    {
        ILoanAccount loan = abAbstractFactory.CreateLoanAccount();
        ISavingAccount savingAccount = abAbstractFactory.CreateSavingAccount();
    }
}