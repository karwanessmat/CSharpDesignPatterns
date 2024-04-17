using Visitor1Demo._2_Create_Concrete_Visitors;
using Visitor1Demo._4__Implement_Concrete_Elements;

var city = new City { Name = "Erbil" };
var industry = new Industry { Type = "Manufacturing" };
var sightSeeing = new SightSeeing { Name = "Statue of Liberty" };

var visitor = new XmlExportVisitor();


// now we have city, industry, and sightseeing 
// visitor can visit one of the above we instantiated 

// visitor visits city
city.Accept(visitor);

// visitor visits industry
industry.Accept(visitor);

// visitor visit sightseeing
sightSeeing.Accept(visitor);