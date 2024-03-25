using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer2Demo.Observer;
using Observer2Demo.Subject;

namespace Observer2Demo.ConcreteObserver
{

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor: IInvestor
    {
        private string name;
        public Stock Stock { get; set; }

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {name} of {stock.Symbol} change to {stock.Price:c}");
        }
    }
}
