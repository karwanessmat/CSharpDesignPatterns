using Visitor3Demo._1_Visitor_Interface;
using Visitor3Demo._3_Define_the_Element_Interface;

namespace Visitor3Demo._4__Implement_Concrete_Elements;

public class Circle : IShape
{
    public void Accept(IShapeVisitor visitor)
    {
        visitor.VisitCircle(this);
    }
}