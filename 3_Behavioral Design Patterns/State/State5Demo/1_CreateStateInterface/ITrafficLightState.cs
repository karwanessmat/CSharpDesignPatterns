using State5Demo._3_ContextClass;

namespace State5Demo._1_CreateStateInterface;
public interface ITrafficLightState
{
    void Handle(TrafficLight context);
}
