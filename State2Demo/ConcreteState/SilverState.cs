using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State2Demo.Context;

namespace State2Demo.ConcreteState
{
    public class SilverState : State.State
    {
        // Overloaded constructors
        public SilverState(State.State state) :
            this(state.Balance, state.Account)
        {
        }
        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
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
