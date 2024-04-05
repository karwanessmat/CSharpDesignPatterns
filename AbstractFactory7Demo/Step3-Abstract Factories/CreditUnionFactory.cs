using AbstractFactory6Demo.step1_AbstractProduct;

namespace AbstractFactory6Demo.Step3_Abstract_Factories
{
    // step1-Abstract Product
    public abstract class CreditUnionFactory
    {
        public abstract ISavingAccount CreateSavingAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }
}
