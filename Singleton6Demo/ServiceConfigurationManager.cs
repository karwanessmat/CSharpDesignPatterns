namespace Singleton6Demo;

public class ServiceConfigurationManager
{
    private static ServiceConfigurationManager _instance;
    private static readonly object _lock = new object();


    private readonly Dictionary<string, Dictionary<string, string?>> _serviceConfiguration;

    private ServiceConfigurationManager()
    {
        _serviceConfiguration = new Dictionary<string, Dictionary<string, string?>>()
        {
            { "Development", LoadDevelopmentConfigurations()! },
            { "Staging", LoadStagingConfigurations() ! },
            { "Production", LoadProductionConfigurations() ! }
        };
    }

    // Public method to get the instance
    public static ServiceConfigurationManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ServiceConfigurationManager();
                }
            }
            return _instance;
        }
    }

    // Methods to load configurations for each environment
    private Dictionary<string, string> LoadDevelopmentConfigurations()
    {
        // Logic to load development configurations, e.g., from a JSON file
        return new Dictionary<string, string>
        {
            {"PaymentGatewayApiKey", "dev-api-key"},
            {"EmailServiceUrl", "https://dev-emailservice.com/api/send"}
            // Other development configurations
        };
    }

    private Dictionary<string, string> LoadStagingConfigurations()
    {
        // Logic to load staging configurations
        return new Dictionary<string, string>
        {
            {"PaymentGatewayApiKey", "staging-api-key"},
            {"EmailServiceUrl", "https://staging-emailservice.com/api/send"}
            // Other staging configurations
        };
    }

    private Dictionary<string, string> LoadProductionConfigurations()
    {
        // Logic to load production configurations
        return new Dictionary<string, string>
        {
            {"PaymentGatewayApiKey", "prod-api-key"},
            {"EmailServiceUrl", "https://emailservice.com/api/send"}
            // Other production configurations
        };
    }


    public string? GetConfiguration(string environment, string key)
    {
        if (_serviceConfiguration.ContainsKey(environment) &&
            _serviceConfiguration[environment].TryGetValue(key, out var value))
        {
            return value;
        }

        return string.Empty;

    }
}