﻿using System;
using Prototype1Demo.Step2_ConcretePrototypes;
using Prototype1Demo.Step3_Prototype_Registry__Client_;

namespace Prototype1Demo;

class Program
{
    static void Main(string[] args)
    {
        var sandwichMenu = new SandwichMenu
        {
            // Initialize with default sandwiches
            ["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato"),
            ["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly"),
            ["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato"),

            // Deli manager adds custom sandwiches
            ["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives"),
            ["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion"),
            ["Vegetarian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach")
        };


        // Now we can clone these sandwiches
        var sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
        var sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
        var sandwich3 = sandwichMenu["Vegetarian"].Clone() as Sandwich;

        // Wait for user
        Console.ReadKey();        }
}