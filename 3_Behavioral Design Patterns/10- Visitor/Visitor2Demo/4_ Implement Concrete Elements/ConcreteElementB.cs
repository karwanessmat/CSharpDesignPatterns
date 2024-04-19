using Visitor2Demo._1_Visitor_Interface;
using Visitor2Demo._3_Define_the_Element_Interface;

namespace Visitor2Demo._4__Implement_Concrete_Elements;

public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }

    // Additional methods specific to ConcreteElementB can be added here
}