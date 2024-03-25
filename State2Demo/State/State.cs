using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State2Demo.Context;

namespace State2Demo.State
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
