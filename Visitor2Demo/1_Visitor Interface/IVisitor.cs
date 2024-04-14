using Visitor2Demo._4__Implement_Concrete_Elements;

namespace Visitor2Demo._1_Visitor_Interface;

public interface IVisitor
{
    void VisitConcreteElementA(ConcreteElementA elementA);
    void VisitConcreteElementB(ConcreteElementB elementB);
}
