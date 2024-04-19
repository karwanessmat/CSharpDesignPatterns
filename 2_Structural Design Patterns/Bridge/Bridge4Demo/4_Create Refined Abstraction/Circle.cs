using Bridge4Demo._1_Define_Implementor_Interface;
using Bridge4Demo._3_Define_Abstraction;

namespace Bridge4Demo._4_Create_Refined_Abstraction;


// Refined Abstraction
public class Circle(double radius, IAreaCalculator areaCalculator) : IShape
{
    public double CalculateArea()
    {
        return areaCalculator.CalculateArea(radius);
    }
}