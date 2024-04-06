using Singleton4Demo;

var appSettings = AppConfigurations.Instance;
Console.WriteLine(appSettings.GetSetting("ConnectionString"));
Console.WriteLine(appSettings.GetSetting("ApiKeyName"));
// Use connectionString and apiKey in your application
