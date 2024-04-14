using Visitor3Demo._1_Visitor_Interface;
using Visitor3Demo._4__Implement_Concrete_Elements;

namespace Visitor3Demo._2_Create_Concrete_Visitors;

public class SaveVisitor : IShapeVisitor
{
    public void VisitCircle(Circle circle)
    {
        Console.WriteLine("Saving a circle to file.");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        Console.WriteLine("Saving a rectangle to file.");
    }

    public void VisitLine(Line line)
    {
        Console.WriteLine("Saving a line to file.");
    }
}