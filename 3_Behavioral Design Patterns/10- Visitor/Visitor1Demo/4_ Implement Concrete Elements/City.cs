using Visitor1Demo._1_Visitor_Interface;
using Visitor1Demo._3_Define_the_Element_Interface;

namespace Visitor1Demo._4__Implement_Concrete_Elements;

public class City : IElement
{
    public string? Name { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitCity(this);
    }
}