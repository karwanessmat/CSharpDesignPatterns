using Singleton6Demo;

string? environment = "Development";
string? getSettings = ServiceConfigurationManager.Instance.GetConfiguration(environment, "EmailServiceUrl");
Console.WriteLine(getSettings);
Console.WriteLine();

string currentEnvironment = "Production";
var paymentService = new PaymentService(currentEnvironment);
paymentService.ProcessPayment();