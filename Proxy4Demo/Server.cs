using System;

namespace Proxy4Demo
{
    /// <summary>
    /// The RealSubject class which the Proxy can stand in for
    /// </summary>
    internal class Server : IServer
    {
        private string _order;
        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            _order = order;
        }

        public string DeliverOrder()
        {
            return _order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }
}
