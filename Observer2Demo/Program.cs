using System;
using Observer2Demo.ConcreteObserver;
using Observer2Demo.ConcreteSubject;

namespace Observer2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibm = new IBM("IBM",250);
            ibm.Attach(new Investor("Network"));
            ibm.Attach(new Investor("Personal Computer"));
            ibm.Attach(new Investor("Personal test"));

            // Fluctuating prices will notify investors
            ibm.Price = 250.55;
            ibm.Price = 150;
            ibm.Price = 177.88;
            ibm.Price = 250;

            Console.ReadKey();
        }
    }
}
