using Visitor2Demo._1_Visitor_Interface;
using Visitor2Demo._2_Create_Concrete_Visitors;
using Visitor2Demo._3_Define_the_Element_Interface;
using Visitor2Demo._4__Implement_Concrete_Elements;

List<IElement> elements = new List<IElement>
{
    new ConcreteElementA(),
    new ConcreteElementB()
};

IVisitor visitor1 = new ConcreteVisitor1();
IVisitor visitor2 = new ConcreteVisitor2();

foreach (var element in elements)
{
    element.Accept(visitor1);
    element.Accept(visitor2);
}