using Visitor4Demo._1_Visitor_Interface;
using Visitor4Demo._3_Define_the_Element_Interface;

namespace Visitor4Demo._4__Implement_Concrete_Elements;

public class Book(double weight) : IProduct
{
    public double Weight { get; set; } = weight;

    public double Accept(IShippingVisitor visitor)
    {
        return visitor.VisitBook(this);
    }
}