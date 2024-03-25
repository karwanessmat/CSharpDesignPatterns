using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer2Demo.Observer;

namespace Observer2Demo.Subject
{
    /// <summary>
    /// the Subject abstract class
    /// </summary>
    public abstract class Stock
    {
        private readonly List<IInvestor> _investors = 
            new List<IInvestor>();

        protected Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
            Console.WriteLine("");

        }

        public string Symbol { get; }

        private double _price;

        public double Price
        {
            get => _price;
            set
            {
                if (_price == value) return;
                _price = value;
                Notify();
            }
        }

    }
}
