using Visitor4Demo._1_Visitor_Interface;

namespace Visitor4Demo._3_Define_the_Element_Interface;

public interface IProduct
{
    double Accept(IShippingVisitor visitor);
}
