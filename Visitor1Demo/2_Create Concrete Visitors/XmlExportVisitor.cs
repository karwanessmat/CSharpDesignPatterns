using Visitor1Demo._1_Visitor_Interface;
using Visitor1Demo._4__Implement_Concrete_Elements;

namespace Visitor1Demo._2_Create_Concrete_Visitors;
public class XmlExportVisitor : IVisitor
{
    public void VisitCity(City city)
    {
        Console.WriteLine($"Exporting City {city.Name} to XML.");
    }

    public void VisitIndustry(Industry industry)
    {
        Console.WriteLine($"Exporting Industry {industry.Type} to XML.");
    }

    public void VisitSightSeeing(SightSeeing sightSeeing)
    {
        Console.WriteLine($"Exporting Sightseeing {sightSeeing.Name} to XML.");
    }
}

