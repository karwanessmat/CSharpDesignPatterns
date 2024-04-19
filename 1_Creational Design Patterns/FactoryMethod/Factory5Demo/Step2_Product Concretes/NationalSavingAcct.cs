using Factory5Demo.Step1_Product_Interface;

namespace Factory5Demo.Step2_Product_Concretes;

public class NationalSavingAcct : SavingsAccount
{
    public NationalSavingAcct()
    {
        Balance = 2000;
    }
}