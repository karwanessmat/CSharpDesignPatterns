namespace Singleton4Demo;

public class AppConfigurations
{
    // Holds the single instance of AppConfigurations

    // Dictionary to hold configuration key-value pairs
    private Dictionary<string, string?> _settings;

    // Private constructor for singleton implementation
    private AppConfigurations()
    {
        // Imagine this method loads the settings from a file or database
        LoadSettings();
    }

    // Public method to get the instance
    public static AppConfigurations Instance { get; } = new();

    // Method to load settings
    private void LoadSettings()
    {
        // Load the settings from a file or database
        _settings = new Dictionary<string, string?>
        {
            {"ConnectionString", "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"},
            {"ApiKeyName", "123456-api-key"},
            // ... more settings
        };
    }

    // Method to get a setting value by key
    public string GetSetting(string key)
    {
        return _settings.GetValueOrDefault(key)!;
    }
}