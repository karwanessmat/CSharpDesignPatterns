using State2Demo._1_CreateStateInterface;
using State2Demo._3_ContextClass;

namespace State2Demo._2_ImplementConcreteStates
{
    public class SilverState : State
    {
 
        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        // Overloaded constructors
        public SilverState(State state) :
            this(state.Balance, state.Account)
        {
        }
        private void Initialize()
        {
            // Should come from a datasource
            Interest = 0.0;
            LowerLimit = 0.0;
            UpperLimit = 1000.0;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }
        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }
        public override void PayInterest()
        {
            Balance += Interest * Balance;
            StateChangeCheck();
        }
        private void StateChangeCheck()
        {
            if (Balance < LowerLimit)
            {
                Account.State = new RedState(this);
            }
            else if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }
}
