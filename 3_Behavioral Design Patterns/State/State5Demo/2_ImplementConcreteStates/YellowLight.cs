using State5Demo._1_CreateStateInterface;
using State5Demo._3_ContextClass;

namespace State5Demo._2_ImplementConcreteStates;

public class YellowLight : ITrafficLightState
{
    public void Handle(TrafficLight context)
    {
        Console.WriteLine("Yellow light - caution!");
        Thread.Sleep(2000); // Yellow light for 2 seconds
        context.SetState(new RedLight());
    }
}