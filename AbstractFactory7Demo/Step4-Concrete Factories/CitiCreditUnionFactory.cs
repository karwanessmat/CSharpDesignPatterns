using AbstractFactory6Demo.step1_AbstractProduct;
using AbstractFactory6Demo.Step2_ConcreteProduct;
using AbstractFactory6Demo.Step3_Abstract_Factories;

namespace AbstractFactory6Demo.Step4_Concrete_Factories;
    public class CitiCreditUnionFactory:CreditUnionFactory
    {
        public override ISavingAccount CreateSavingAccount()
        {
            return new CitiSavingAccount();
        }

        public override ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }
    }

public class NationalCreditUnionFactory:CreditUnionFactory
{
    public override ISavingAccount CreateSavingAccount()
    {
        return new NationalSavingAccount();
    }

    public override ILoanAccount CreateLoanAccount()
    {
        return new NationalLoanAccount();
    }
}

