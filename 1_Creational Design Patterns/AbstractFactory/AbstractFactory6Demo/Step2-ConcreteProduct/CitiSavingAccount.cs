using AbstractFactory6Demo.step1_AbstractProduct;

namespace AbstractFactory6Demo.Step2_ConcreteProduct;
    public class CitiSavingAccount:ISavingAccount
    {
        public CitiSavingAccount() 
        {
            Console.WriteLine("Returned Citi Savings Account");
        }
    }