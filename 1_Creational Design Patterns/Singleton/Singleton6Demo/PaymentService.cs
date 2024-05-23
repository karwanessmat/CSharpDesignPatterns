namespace Singleton6Demo;

public class PaymentService(string environment)
{
    private readonly string _apiKey = ServiceConfigurationManager.Instance.GetConfiguration(environment, "PaymentGatewayApiKey");

    // Use the _apiKey for payment transactions

    public void ProcessPayment()
    {
        // Use the _apiKey to authenticate and process payments
    }
}