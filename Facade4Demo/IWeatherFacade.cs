using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade4Demo.Entities;

namespace Facade4Demo;

public interface IWeatherFacade
{
    WeatherFacadeResults GetTempInCity(string zipCode);
}