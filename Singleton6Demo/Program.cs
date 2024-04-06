using Singleton6Demo;

var environment = "Development";
var getSettings = ServiceConfigurationManager.Instance.GetConfiguration(environment, "EmailServiceUrl");
Console.WriteLine(getSettings);
Console.WriteLine();

string currentEnvironment = "Production";
PaymentService paymentService = new PaymentService(currentEnvironment);
paymentService.ProcessPayment();