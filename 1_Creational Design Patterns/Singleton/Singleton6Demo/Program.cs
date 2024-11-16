using Singleton6Demo;

// get as test of result development 
const string environment = "Development";
var apiKeyDevelopmentEnvironment = 
    ServiceConfigurationManager.Instance.GetConfiguration(environment, "PaymentGatewayApiKey");

var emailDevelopmentEnvironment =
    ServiceConfigurationManager.Instance.GetConfiguration(environment, "EmailServiceUrl");

Console.WriteLine(apiKeyDevelopmentEnvironment);
Console.WriteLine(emailDevelopmentEnvironment);

Console.WriteLine();
Console.WriteLine("The payment service to process");
// using the paymentService to process
const string currentEnvironment = "Production";
var paymentService = new PaymentService(currentEnvironment);
paymentService.ProcessPayment();