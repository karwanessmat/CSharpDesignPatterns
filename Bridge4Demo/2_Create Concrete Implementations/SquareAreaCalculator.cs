using Bridge4Demo._1_Define_Implementor_Interface;

namespace Bridge4Demo._2_Create_Concrete_Implementations;

// Concrete Implementation
public class SquareAreaCalculator : IAreaCalculator
{
    public double CalculateArea(params double[] dimensions)
    {
        var side = dimensions[0];
        return side * side;
    }
}