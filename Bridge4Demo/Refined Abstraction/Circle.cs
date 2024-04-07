using Bridge4Demo.Abstraction;
using Bridge4Demo.Implementor;

namespace Bridge4Demo.Refined_Abstraction;


// Refined Abstraction
public class Circle(double radius, IAreaCalculator areaCalculator) : IShape
{
    public double CalculateArea()
    {
        return areaCalculator.CalculateArea(radius);
    }
}