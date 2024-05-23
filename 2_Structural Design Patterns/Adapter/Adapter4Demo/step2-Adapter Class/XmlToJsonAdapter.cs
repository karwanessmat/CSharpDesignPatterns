using System;
using System.Collections.Generic;
using System.Linq;
using Adapter4Demo.Step1___Interface;
using Adapter4Demo.Step3_Client___Adaptee;

namespace Adapter4Demo.step2_Adapter_Class;

/// <summary>
/// Adapter
/// </summary>
public class XmlToJsonAdapter(XmlConverter xmlConverter) : IXmlToJson
{
    // we are using this method to match between incompatible objects.
    // for example, convert xml to json
    // we must use ConvertXmlToJson() method that came form IXmlToJson interface
    public void ConvertXmlToJson()
    {
        IEnumerable<Manufacturer> manufacturers = xmlConverter.GetXml()
            .Element("Manufacturers")
            ?.Elements("Manufacturer")
            .Select(m => new Manufacturer
            {
                City = m.Attribute("City")?.Value,
                Name = m.Attribute("Name")?.Value,
                Year = Convert.ToInt32(m.Attribute("Year")?.Value)
            });

        // helper 
        var data = new JsonConverter(manufacturers);
        data.ConvertToJson();
    }
}