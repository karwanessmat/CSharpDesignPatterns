using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State5Demo._1_CreateStateInterface;
using State5Demo._2_ImplementConcreteStates;

namespace State5Demo._3_ContextClass;

public class TrafficLight
{
    private  ITrafficLightState _state = new RedLight();

    public void SetState(ITrafficLightState state)
    {
        _state = state;
    }

    public void Change()
    {
        _state.Handle(this);
    }
}
