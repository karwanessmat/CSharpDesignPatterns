using Factory5Demo.Product;

namespace Factory5Demo.Concrete_Products
{
    public class CitiSavingsAcct:SavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }
}
