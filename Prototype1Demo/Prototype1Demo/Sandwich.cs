using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1Demo
{
    internal class Sandwich : SandwichPrototype
    {
        private string _bread;
        private string _meat;
        private string _cheese;
        private string _veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            _bread = bread;
            _meat = meat;
            _cheese = cheese;
            _veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            var ingredientList = GetIngredientList();
            Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList
                                                                        .Remove(ingredientList.LastIndexOf(",", StringComparison.Ordinal)));

            return MemberwiseClone() as SandwichPrototype;
        }

        private static string GetIngredientList()
        {
            //...

            return "one,tow,three";
        }
    }
}
