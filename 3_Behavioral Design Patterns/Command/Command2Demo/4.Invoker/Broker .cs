using System.Collections.Generic;
using Command2Demo._1.Command_Interface;

namespace Command2Demo._4.Invoker;

// command invoker class.
public class Broker
{
    private readonly List<IOrder> _orderList = [];

    public void TakeOrder(IOrder order)
    {
        _orderList.Add(order);
    }

    public void PlaceOrders(int value)
    {

        foreach (var order in _orderList)
        {
            order.Execute(value);
        }
        _orderList.Clear();
    }
}