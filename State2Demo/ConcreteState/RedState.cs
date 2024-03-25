using System;

namespace State2Demo.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    public class RedState : State.State
    {
        private double _serviceFee;
        // Constructor
        public RedState(State.State state)
        {
            this.Balance = state.Balance;
            this.Account = state.Account;
            Initialize();
        }
        private void Initialize()
        {
            // Should come from a dataSource
            Interest = 0.0;
            LowerLimit = -100.0;
            UpperLimit = 0.0;
            _serviceFee = 15.00;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }
        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }
        public override void PayInterest()
        {
            // No interest is paid
        }
        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }
    }
}
