using System;
using Observer4Demo.Step1_Define_Observer_Interface;
using Observer4Demo.Step2_Define_Subject_Interface;

namespace Observer4Demo.Step4_Implement_Concrete_Observers;

public class Restaurant(string name, double purchaseThreshold) : IRestaurant
{

    public void Update(Vegetable veggie)
    {
        Console.WriteLine($"Notified {name} of {veggie.GetType().Name}'s price change to {veggie.PricePerPound:C} per pound.");

        if (!(veggie.PricePerPound < purchaseThreshold)) 
            return;

        Console.WriteLine(name + " wants to buy some "+ veggie.GetType().Name + "!");
        Console.WriteLine();


    }
}