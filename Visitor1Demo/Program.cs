using Visitor1Demo._2_Create_Concrete_Visitors;
using Visitor1Demo._4__Implement_Concrete_Elements;

var city = new City { Name = "Erbil" };
var industry = new Industry { Type = "Manufacturing" };
var sightSeeing = new SightSeeing { Name = "Statue of Liberty" };

var visitor = new XmlExportVisitor();

city.Accept(visitor);
industry.Accept(visitor);
sightSeeing.Accept(visitor);