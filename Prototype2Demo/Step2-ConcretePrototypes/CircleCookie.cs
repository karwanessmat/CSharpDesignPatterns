

using Prototype2Demo.Step1_Prototype_interface;

namespace Prototype2Demo.Step2_ConcretePrototypes;

public class CircleCookie(int diameter) : Cookie
{
    public int Diameter { get; set; } = diameter;

    // Implementing the Clone method
    public override Cookie Clone()
    {
        return new CircleCookie(Diameter);
    }
}