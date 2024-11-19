using Decorator2Demo._1_Component_Interface;

namespace Decorator2Demo._2_Create_a_Concrete_Component;

class LuxuryCar:ICar
{
    public string GetDescription()
    {
        return "Luxury Car";
    }
    public double GetCost()
    {
        return 1000 - 000.0;
    }
}