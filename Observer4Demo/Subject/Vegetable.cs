using System;
using System.Collections.Generic;
using Observer4Demo.Observer;

namespace Observer4Demo.Subject
{
    public class Vegetable(double pricePerPound)
    {
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return pricePerPound; }
            set
            {
                if (pricePerPound != value)
                {
                    pricePerPound = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }

    }
}
