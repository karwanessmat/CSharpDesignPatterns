using System;
using Observer2Demo.Observer;
using Observer2Demo.Subject;

namespace Observer2Demo.ConcreteObserver
{

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor(string name) : IInvestor
    {
        public Stock Stock { get; set; }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {name} of {stock.Symbol} change to {stock.Price:c}");
        }
    }
}
