using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton6Demo
{
    public class PaymentService
    {
        private readonly string _apiKey;

        public PaymentService(string environment)
        {
            _apiKey = ServiceConfigurationManager.Instance.GetConfiguration(environment, "PaymentGatewayApiKey");
            // Use the _apiKey for payment transactions

        }

        public void ProcessPayment()
        {
            // Use the _apiKey to authenticate and process payments
        }
    }
}
