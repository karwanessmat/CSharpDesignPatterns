namespace Singleton4Demo;

public class AppConfigurations
{
    // Dictionary to hold configuration key-value pairs
    private Dictionary<string, string?> _settings;

    // Private constructor for singleton implementation
    private AppConfigurations()
    {
        LoadSettings();
    }

    // Public method to get the instance
    public static AppConfigurations Instance { get; } = new();

    private void LoadSettings()
    {
        _settings = new Dictionary<string, string?>
        {
            {"ConnectionString", "Your ConnectionString;"},
            {"ApiKeyName", "123456-api-key"},
            // ... more settings
        };
    }

    public string GetSetting(string key)
    {
        return _settings.GetValueOrDefault(key)!;
    }
}