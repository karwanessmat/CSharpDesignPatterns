using Facade4Demo.Entities;

namespace Facade4Demo;

public interface IWeatherFacade
{
    WeatherFacadeResults GetTempInCity(string zipCode);
}