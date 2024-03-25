using System;
using Observer4Demo.Observer;
using Observer4Demo.Subject;

namespace Observer4Demo.ConcreteObserver
{
    public class Restaurant:IRestaurant
    {
        private readonly string _name;
        private Vegetable _veggie;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Vegetable veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s "
                              + " price change to {2:C} per pound.",
                _name, veggie.GetType().Name, veggie.PricePerPound);
            if (veggie.PricePerPound < _purchaseThreshold)
            {
                Console.WriteLine(_name + " wants to buy some "
                                        + veggie.GetType().Name + "!");
                Console.WriteLine();

            }


        }
    }
}
