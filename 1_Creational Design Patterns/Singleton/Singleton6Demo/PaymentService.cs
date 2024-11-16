namespace Singleton6Demo;

public class PaymentService(string environment)
{
    private readonly string? _apiKey = 
        ServiceConfigurationManager.Instance.GetConfiguration(environment, "PaymentGatewayApiKey");


    public void ProcessPayment()
    {
        // Use the _apiKey to authenticate and process payments
        Console.WriteLine(_apiKey);
    }
}