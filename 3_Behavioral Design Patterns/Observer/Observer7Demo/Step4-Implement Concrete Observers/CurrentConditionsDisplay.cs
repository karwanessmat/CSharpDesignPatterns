using Observer7Demo.Step1_Define_Observer_Interface;
using Observer7Demo.Step3_Implement_Concrete_Subject;

namespace Observer7Demo.Step4_Implement_Concrete_Observers;
public class CurrentConditionsDisplay : IObserver
{
    private readonly WeatherStation _weatherStation;

    public CurrentConditionsDisplay(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine($"Current conditions: {_weatherStation.Temperature}°F");
    }
}
