
using Singleton4Demo;

AppConfigurations? appSettings = AppConfigurations.Instance;
Console.WriteLine(appSettings.GetSetting("ConnectionString"));
Console.WriteLine(appSettings.GetSetting("ApiKeyName"));
