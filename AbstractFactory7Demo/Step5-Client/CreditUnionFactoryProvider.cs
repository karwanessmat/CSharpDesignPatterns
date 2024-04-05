using AbstractFactory6Demo.Step3_Abstract_Factories;
using AbstractFactory6Demo.Step4_Concrete_Factories;

namespace AbstractFactory6Demo.Step5_Client
{
    public class CreditUnionFactoryProvider
    {
        public static CreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI"))
            {
                return new CitiCreditUnionFactory();
            }else if (accountNo.Contains("NATIONAL"))
            {
                return new NationalCreditUnionFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
