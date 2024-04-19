using Visitor1Demo._1_Visitor_Interface;

namespace Visitor1Demo._3_Define_the_Element_Interface;
public interface IElement
{
    void Accept(IVisitor visitor);
}
