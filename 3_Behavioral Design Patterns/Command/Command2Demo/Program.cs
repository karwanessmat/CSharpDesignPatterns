using System;
using Command2Demo._2.Concrete_Commands;
using Command2Demo._3.Receiver;
using Command2Demo._4.Invoker;

namespace Command2Demo;

class Program
{
    static void Main(string[] args)
    {

        var abcStock = new Stock();

        var buyStockOrder = new BuyStock(abcStock);
        var sellStockOrder = new SellStock(abcStock);

        var broker = new Broker();
        broker.TakeOrder(buyStockOrder);
        broker.TakeOrder(sellStockOrder);

        broker.PlaceOrders(50);


        Console.ReadLine();
    }
}