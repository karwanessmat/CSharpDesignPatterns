using System;

namespace Command2Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var abcStock = new Stock();

            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            //broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders(50);


            Console.ReadLine();
        }
    }
}
