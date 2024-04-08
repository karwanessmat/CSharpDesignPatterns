using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator5Demo._1.Component;

namespace Decorator5Demo._2.ConcreteComponents;
    public class SmsNotifier:INotifier
    {
    
        public void Send(string message)
        {
            Console.WriteLine($"Sms: {message}");

    }
}