using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy4Demo
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    internal class NewServerProxy : IServer
    {
        private string _order;
        private readonly Server _server = new Server();

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
