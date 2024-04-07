using Bridge4Demo.Abstraction;
using Bridge4Demo.Concrete_Implementation;
using Bridge4Demo.Refined_Abstraction;

IShape circleArea = new Rectangle(2,4,new RectangleAreaCalculator());
Console.WriteLine($"Area: {circleArea.CalculateArea()}");