using Visitor7Demo._1_Visitor_Interface;

namespace Visitor7Demo._3_Define_the_Element_Interface;

internal interface IComponent
{
    string Accept(IVisitor visitor, string text);
}