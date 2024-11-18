using Bridge4Demo._2_Create_Concrete_Implementations;
using Bridge4Demo._3_Define_Abstraction;
using Bridge4Demo._4_Create_Refined_Abstraction;

// Using RectangleAreaCalculator with a Rectangle
IShape rectangle = new Rectangle(5, 10, new RectangleAreaCalculator());
Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");

// Using CircleAreaCalculator with a Circle
IShape circle = new Circle(7, new CircleAreaCalculator());
Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

// Using SquareAreaCalculator with a Square
IShape square = new Square(4, new SquareAreaCalculator());
Console.WriteLine($"Square Area: {square.CalculateArea()}");
