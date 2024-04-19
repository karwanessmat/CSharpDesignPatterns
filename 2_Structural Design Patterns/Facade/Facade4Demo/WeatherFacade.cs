using Facade4Demo.Entities;
using Facade4Demo.Services;

namespace Facade4Demo;

public class WeatherFacade(
    ConverterService converterService,
    GeoLookupService geoLookUpService,
    WeatherService weatherService)
    : IWeatherFacade
{
    public WeatherFacade() :
        this(new ConverterService(), 
            new GeoLookupService(), 
            new WeatherService())
    {

    }

    public WeatherFacadeResults GetTempInCity(string zipCode)
    {
        var city = geoLookUpService.GetCityForZipCode(zipCode);
        var state = geoLookUpService.GetStateForZipCode(zipCode);
        var tempF = weatherService.GetTempFahrenheit(city, state);
        var tempC = converterService.ConvertFahrenheitToCelsius(tempF);

        var results = new WeatherFacadeResults
        {
            City = city,
            State = state,
            Fahrenheit = tempF,
            Celsius = tempC
        };

        return results;
    }
}
