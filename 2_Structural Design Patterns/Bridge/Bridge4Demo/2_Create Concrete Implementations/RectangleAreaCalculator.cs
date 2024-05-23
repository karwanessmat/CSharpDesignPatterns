using Bridge4Demo._1_Define_Implementor_Interface;

namespace Bridge4Demo._2_Create_Concrete_Implementations;

// Concrete Implementation
public class RectangleAreaCalculator : IAreaCalculator
{
    public double CalculateArea(params double[] dimensions)
    {
        double width = dimensions[0];
        double height = dimensions[1];
        return width * height;
    }
}