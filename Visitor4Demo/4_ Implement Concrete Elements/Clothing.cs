using Visitor4Demo._1_Visitor_Interface;
using Visitor4Demo._3_Define_the_Element_Interface;

namespace Visitor4Demo._4__Implement_Concrete_Elements;

public class Clothing : IProduct
{
    public Clothing()
    {
    }

    public double Accept(IShippingVisitor visitor)
    {
        return visitor.VisitClothing(this);
    }
}