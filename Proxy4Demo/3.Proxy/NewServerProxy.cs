using System;
using Proxy4Demo._1._Subject_Interface;
using Proxy4Demo._2.RealSubject;

namespace Proxy4Demo._3.Proxy
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    internal class NewServerProxy : IServer
    {
        private string _order;
        private readonly Server _server = new();

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            _order = order;
        }

        public string DeliverOrder()
        {
            return _order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
