using Bridge4Demo.Abstraction;
using Bridge4Demo.Implementor;

namespace Bridge4Demo.Refined_Abstraction;


// Refined Abstraction
public class Square(double side, IAreaCalculator areaCalculator) : IShape
{
    public double CalculateArea()
    {
        return areaCalculator.CalculateArea(side);
    }
}