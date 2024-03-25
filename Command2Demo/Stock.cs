using System;

namespace Command2Demo
{
    //request Class
    public class Stock
    {
        private const string Name = "ABC";
        private  int _quantity = 10;

        public void Buy(int addQuantity)
        {
            _quantity += addQuantity;
            Console.WriteLine("Stock [ Name: " + Name + ", Quantity: " + _quantity +" ] bought");
        }
        public void Sell(int removeQuantity)
        {
            _quantity -= removeQuantity;
            Console.WriteLine("Stock [ Name: " + Name + ", Quantity: " + _quantity +" ] sold");
        }
    }
}
