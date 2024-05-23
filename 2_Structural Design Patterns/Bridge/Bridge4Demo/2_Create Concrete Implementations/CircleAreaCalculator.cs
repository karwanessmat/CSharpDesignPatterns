using Bridge4Demo._1_Define_Implementor_Interface;

namespace Bridge4Demo._2_Create_Concrete_Implementations;


// Concrete Implementation
public class CircleAreaCalculator : IAreaCalculator
{
    public double CalculateArea(params double[] dimensions)
    {
        double radius = dimensions[0];
        return Math.PI * radius * radius;
    }
}



