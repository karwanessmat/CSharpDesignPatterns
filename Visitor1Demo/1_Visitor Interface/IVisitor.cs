using Visitor1Demo._4__Implement_Concrete_Elements;

namespace Visitor1Demo._1_Visitor_Interface;

public interface IVisitor
{
    void VisitCity(City city);
    void VisitIndustry(Industry industry);
    void VisitSightSeeing(SightSeeing sightSeeing);
}
