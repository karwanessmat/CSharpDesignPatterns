using Prototype2Demo.Step1_Prototype_interface;

namespace Prototype2Demo.Step2_ConcretePrototypes;

public class SquareCookie(int sideLength) : Cookie
{
    public int SideLength { get; set; } = sideLength;
    public override Cookie Clone()
    {
        return new SquareCookie(SideLength);
    }
}