using Bridge4Demo._2_Create_Concrete_Implementations;
using Bridge4Demo._3_Define_Abstraction;
using Bridge4Demo._4_Create_Refined_Abstraction;

IShape circleArea = new Rectangle(2,4,new RectangleAreaCalculator());
Console.WriteLine($"Area: {circleArea.CalculateArea()}");