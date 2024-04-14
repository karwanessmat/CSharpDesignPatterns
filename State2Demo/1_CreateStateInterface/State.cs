using State2Demo._3_ContextClass;

namespace State2Demo._1_CreateStateInterface
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>

    public abstract class State
    {

        protected double Interest;
        protected double LowerLimit;
        protected double UpperLimit;

        public double Balance { get; set; }
        public Account Account { get; set; }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();



    }
}
