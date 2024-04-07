using Bridge4Demo.Implementor;

namespace Bridge4Demo.Concrete_Implementation;

// Concrete Implementation
public class RectangleAreaCalculator : IAreaCalculator
{
    public double CalculateArea(params double[] dimensions)
    {
        var width = dimensions[0];
        var height = dimensions[1];
        return width * height;
    }
}