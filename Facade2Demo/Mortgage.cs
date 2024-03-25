using System;

namespace Facade2Demo
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>

   public class Mortgage

    {
        private readonly Bank _bank = new Bank();
        private readonly Loan _loan = new Loan();
        private readonly Credit _credit = new Credit();

        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                customer.Name, amount);

            var eligible = true;

            // Check credit worthyness of applicant

            if (!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer,amount))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}

