using System;
using Observer4Demo.Observer;
using Observer4Demo.Subject;

namespace Observer4Demo.ConcreteObserver
{
    public class Restaurant(string name, double purchaseThreshold) : IRestaurant
    {
        private Vegetable _veggie;

        public void Update(Vegetable veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s "
                              + " price change to {2:C} per pound.",
                name, veggie.GetType().Name, veggie.PricePerPound);
            if (veggie.PricePerPound < purchaseThreshold)
            {
                Console.WriteLine(name + " wants to buy some "
                                        + veggie.GetType().Name + "!");
                Console.WriteLine();

            }


        }
    }
}
