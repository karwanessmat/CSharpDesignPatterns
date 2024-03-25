using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command2Demo
{
    // command invoker class.
    public class Broker
    {
        private readonly List<IOrder> _orderList = new List<IOrder>();

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
}
