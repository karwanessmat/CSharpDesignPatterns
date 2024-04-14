using Visitor4Demo._1_Visitor_Interface;
using Visitor4Demo._4__Implement_Concrete_Elements;

namespace Visitor4Demo._2_Create_Concrete_Visitors;

public class StandardShippingVisitor : IShippingVisitor
{
    public double VisitBook(Book book)
    {
        return book.Weight * 1.05; // Example calculation based on weight
    }

    public double VisitElectronics(Electronics electronics)
    {
        return electronics.Weight * 1.25 + 15; // Fragile items have additional charge
    }

    public double VisitClothing(Clothing clothing)
    {
        return 5; // Flat rate for all clothing
    }
}
