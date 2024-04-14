using Visitor4Demo._4__Implement_Concrete_Elements;

namespace Visitor4Demo._1_Visitor_Interface;
public interface IShippingVisitor
{
    double VisitBook(Book book);
    double VisitElectronics(Electronics electronics);
    double VisitClothing(Clothing clothing);
}
