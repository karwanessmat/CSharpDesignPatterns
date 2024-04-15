using Factory5Demo.Step1_Product_Interface;

namespace Factory5Demo.Step2_Product_Concretes
{
    public class CitiSavingsAcct:SavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }
}
