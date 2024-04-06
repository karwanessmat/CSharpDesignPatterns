using Prototype4Demo.Step1_Prototype_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype4Demo.Step2_ConcretePrototypes
{
    internal class Product(string name, decimal price, string description, string imageUrl)
        : IProductPrototype
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public string Description { get; set; } = description;
        public string ImageUrl { get; set; } = imageUrl;

        // Clone method for creating a new instance of Product with the same values
        // must return new instance
        public IProductPrototype Clone()
        {
            return new Product(Name, Price, description, imageUrl);
            return MemberwiseClone() as Product;
        }
    }
}
