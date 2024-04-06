using System;
using System.Linq;
using Adapter4Demo.Step1___Interface;
using Adapter4Demo.Step3_Client___Adaptee;

namespace Adapter4Demo.step2_Adapter_Class;

/// <summary>
/// Adapter
/// </summary>
public class XmlToJsonAdapter(XmlConverter xmlConverter) : IXmlToJson
{
    public void ConvertXmlToJson()
    {
        var manufacturers = xmlConverter.GetXml()
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