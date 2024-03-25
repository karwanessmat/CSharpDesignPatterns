using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using State2Demo.ConcreteState;

namespace State2Demo.Context
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Account
    {
        private string _owner;
        // Constructor
        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            _owner = owner;
            State = new SilverState(0.0, this);
        }
        public double Balance => State.Balance;
        public State.State State { get; set; }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}",
                State.GetType().Name);
            Console.WriteLine("");
        }
        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}\n",
                State.GetType().Name);
        }
        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}\n",
                State.GetType().Name);
        }
    }
}
