using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State5Demo._3_ContextClass;

namespace State5Demo._1_CreateStateInterface;
public interface ITrafficLightState
{
    void Handle(TrafficLight context);
}
