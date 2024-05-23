using Factory6Demo.Models;
using Factory6Demo;
using Factory6Demo.Step3_Creator;
using Factory6Demo.step4_Concrete_Creator;

var exchange = new Exchange
{
    Name = "BTC",
    Volume_1day_usd = 50000 // Example volume
};

// Create a factory for creating processors
ProcessFactory processFactory = new CryptoCurrencyFactory();

// Create a Forex object with the exchange and factory
var forex = new Forex(exchange, processFactory);

// Get forecast data
List<double>? forecastData = forex.GetForecastData();

// Print the forecast data
foreach (double data in forecastData)
{
    Console.WriteLine($"name {nameof(data)}: data" );
}