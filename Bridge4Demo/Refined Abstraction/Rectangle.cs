using Bridge4Demo.Abstraction;
using Bridge4Demo.Implementor;

namespace Bridge4Demo.Refined_Abstraction;

// Refined Abstraction
public class Rectangle(double width, double height, IAreaCalculator areaCalculator)
    : IShape
{
    public double CalculateArea()
    {
        return areaCalculator.CalculateArea(width, height);
    }
}