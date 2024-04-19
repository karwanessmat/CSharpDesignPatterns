using Factory5Demo.Step1_Product_Interface;
using Factory5Demo.Step2_Product_Concretes;
using Factory5Demo.Step3_Creator;

namespace Factory5Demo.step4_Concrete_Creator
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
            }

            if (acctNo.Contains("NATIONAL"))
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
