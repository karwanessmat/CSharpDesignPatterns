using System;

namespace Command1Demo.receiver
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price for the {Name} has been increased by {amount}$.");
        }

        // the big amount will be wrong 
        //public void DecreasePrice(int amount)
        //{
        //    if (amount >= Price) return;
        //    Price -= amount;
        //    Console.WriteLine($"The price for the {Name} has been decreased by {amount}$.");
        //}


        public bool DecreasePrice(int amount)
        {
            if (amount >= Price) return false;
            Price -= amount;
            Console.WriteLine($"The price for the {Name} has been decreased by {amount}$.");
            return true;
        }

    public override string ToString() =>
            $"Current price for the {Name} product is {Price}$.";
    }
}
