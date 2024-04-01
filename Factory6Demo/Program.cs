using Factory6Demo.Creator_Factories;
using Factory6Demo.Factory_Product__ConcreteCreator;
using Factory6Demo.Models;
using Factory6Demo;

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
var forecastData = forex.GetForecastData();

// Print the forecast data
foreach (var data in forecastData)
{
    Console.WriteLine($"name {nameof(data)}: data" );
}