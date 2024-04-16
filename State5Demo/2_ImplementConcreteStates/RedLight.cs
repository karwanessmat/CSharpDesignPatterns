using State5Demo._1_CreateStateInterface;
using State5Demo._3_ContextClass;

namespace State5Demo._2_ImplementConcreteStates;

public class RedLight:ITrafficLightState
{
    public void Handle(TrafficLight context)
    {
        Console.WriteLine("Red light - stop");
        context.SetState(new GreenLight());
    }
}