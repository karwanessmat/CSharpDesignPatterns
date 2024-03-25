using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy4Demo
{
    /// <summary>
    /// The Subject interface which both the RealSubject and proxy will need to implement
    /// </summary>
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }
}
