using Bridge4Demo.Implementor;

namespace Bridge4Demo.Concrete_Implementation;


// Concrete Implementation
public class CircleAreaCalculator : IAreaCalculator
{
    public double CalculateArea(params double[] dimensions)
    {
        var radius = dimensions[0];
        return Math.PI * radius * radius;
    }
}



