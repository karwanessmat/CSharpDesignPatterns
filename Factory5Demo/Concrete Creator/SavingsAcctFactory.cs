using Factory5Demo.Concrete_Products;
using Factory5Demo.Creator;
using Factory5Demo.Product;

namespace Factory5Demo.Concrete_Creator
{
     /// <summary>
     /// Concrete Creators
     /// </summary>
    public class SavingsAcctFactory:ICreditUnionFactory
    {
        public SavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
            {
                return new CitiSavingsAcct();
            } else if (acctNo.Contains("NATIONAL"))
            {
                return new NationalSavingAcct();
            }
            else
            {
                throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}
