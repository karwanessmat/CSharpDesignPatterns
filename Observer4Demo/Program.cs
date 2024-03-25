using System;
using Observer4Demo.ConcreteObserver;
using Observer4Demo.ConcreteSubject;

namespace Observer4Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create price watch for Carrots 
            // and attach restaurants that buy carrots from suppliers.
            var carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Lele's", 0.77));
            carrots.Attach(new Restaurant("Big land's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Avana", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;

            Console.ReadKey();
        }
    }
}
