using System;
using Prototype1Demo.Step1_Prototype_interface;

namespace Prototype1Demo.Step2_ConcretePrototypes;

internal class Sandwich(string bread, string meat, string cheese, string veggies)
    : SandwichPrototype
{


    public override SandwichPrototype Clone()
    {
        string ingredientList = GetIngredientList();
        Console.WriteLine("Cloning sandwich with ingredients: {0}", 
            ingredientList.Remove(ingredientList.LastIndexOf(",", StringComparison.Ordinal)));

        return MemberwiseClone() as SandwichPrototype;
    }

    private static string GetIngredientList()
    {
        //...

        return "one,tow,three";
    }
}