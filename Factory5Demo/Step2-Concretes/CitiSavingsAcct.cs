using Factory5Demo.Step1_Product;

namespace Factory5Demo.Step2_Concretes
{
    public class CitiSavingsAcct:SavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }
}
