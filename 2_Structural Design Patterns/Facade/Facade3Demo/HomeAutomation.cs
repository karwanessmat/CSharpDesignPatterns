using Facade3Demo.Subsystem_Classes;

namespace Facade3Demo;

//Facade
public class HomeAutomation
{
    private readonly HeatingControl _heatingControl = new();
    private readonly LightingControl _lightingControl = new();
    private readonly SecurityControl _securityControl = new();

    public void DepartHome()
    {
            _heatingControl.DecreaseTemperature();
            _lightingControl.TurnOffLights();
            _securityControl.DeactivateAlarm();
        }

    public void ArriveHome()
    {
            _heatingControl.IncreaseTemperature();
            _lightingControl.TurnOnLights();
            _securityControl.ActivateAlarm();
        }
}