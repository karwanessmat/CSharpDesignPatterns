using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor3Demo._1_Visitor_Interface;
using Visitor3Demo._4__Implement_Concrete_Elements;

namespace Visitor3Demo._2_Create_Concrete_Visitors;
public class RenderVisitor : IShapeVisitor
{
    public void VisitCircle(Circle circle)
    {
        Console.WriteLine("Rendering a circle.");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        Console.WriteLine("Rendering a rectangle.");
    }

    public void VisitLine(Line line)
    {
        Console.WriteLine("Rendering a line.");
    }
}