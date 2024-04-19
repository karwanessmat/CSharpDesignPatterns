using System;
using Observer4Demo.Step3_Implement_Concrete_Subject;
using Observer4Demo.Step4_Implement_Concrete_Observers;

namespace Observer4Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create price watch for Carrots 
            // and attach restaurants that buy carrots from suppliers.
            var carrots = new Carrots(0.82);

            // these Restaurants are registered to  Carrots product
            // if we any changes are being updated then notification will be sent to these restaurants 
            carrots.Attach(new Restaurant("Lele's", 0.77));
            carrots.Attach(new Restaurant("Big land's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Avana", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.

            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;
            // four times notification will be sent to above three restaurants because 
            // four times the price was changed

            Console.ReadKey();
        }
    }
}
