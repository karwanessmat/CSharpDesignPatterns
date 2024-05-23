using System;
using System.Collections.Generic;
using Observer4Demo.Step1_Define_Observer_Interface;

namespace Observer4Demo.Step2_Define_Subject_Interface;

public class Vegetable(double pricePerPound)
{
    private readonly List<IRestaurant> _restaurants = [];
    public double PricePerPound
    {
        get => pricePerPound;
        set
        {
            if (pricePerPound == value) 
                return;

            pricePerPound = value;
            Notify(); //Automatically notify our observers of price changes
        }
    }
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

     

}