using Visitor2Demo._1_Visitor_Interface;
using Visitor2Demo._4__Implement_Concrete_Elements;

namespace Visitor2Demo._2_Create_Concrete_Visitors;
public class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA elementA)
    {
        Console.WriteLine("ConcreteVisitor1: Visiting ConcreteElementA");
    }

    public void VisitConcreteElementB(ConcreteElementB elementB)
    {
        Console.WriteLine("ConcreteVisitor1: Visiting ConcreteElementB");
    }
}

public class ConcreteVisitor2 : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA elementA)
    {
        Console.WriteLine("ConcreteVisitor2: Visiting ConcreteElementA");
    }

    public void VisitConcreteElementB(ConcreteElementB elementB)
    {
        Console.WriteLine("ConcreteVisitor2: Visiting ConcreteElementB");
    }
}
