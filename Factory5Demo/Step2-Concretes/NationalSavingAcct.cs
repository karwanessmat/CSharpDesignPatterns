using Factory5Demo.Step1_Product;

namespace Factory5Demo.Step2_Concretes;

public class NationalSavingAcct : SavingsAccount
{
    public NationalSavingAcct()
    {
        Balance = 2000;
    }
}