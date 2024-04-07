using Bridge4Demo.Implementor;

namespace Bridge4Demo.Concrete_Implementation;

// Concrete Implementation
public class SquareAreaCalculator : IAreaCalculator
{
    public double CalculateArea(params double[] dimensions)
    {
        var side = dimensions[0];
        return side * side;
    }
}