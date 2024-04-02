using Factory5Demo.Step1_Product;
using Factory5Demo.Step2_Concretes;
using Factory5Demo.Step3_Creator;

namespace Factory5Demo.step4_ConcreteCreator
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
