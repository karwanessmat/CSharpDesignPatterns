using Factory5Demo.Product;

namespace Factory5Demo.Concrete_Products;

public class NationalSavingAcct : SavingsAccount
{
    public NationalSavingAcct()
    {
        Balance = 2000;
    }
}