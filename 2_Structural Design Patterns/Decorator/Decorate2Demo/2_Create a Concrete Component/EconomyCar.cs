using Decorator2Demo._1_Component_Interface;

namespace Decorator2Demo._2_Create_a_Concrete_Component;

/// <summary>
/// Concrete Component
/// </summary>
public  class EconomyCar:ICar
{
    public string GetDescription()
    {
        return "Economy Car";
    }
    public double GetCost()
    {
        return 450000.0;
    }
}