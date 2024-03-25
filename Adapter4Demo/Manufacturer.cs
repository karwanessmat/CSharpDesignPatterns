using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Adapter4Demo
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Year { get; set; }
    }


    
    public static class ManufacturerDataProvider
    {
        public static List<Manufacturer> GetData() =>
            new List<Manufacturer>
            {
                new Manufacturer {City = "Italy", Name = "Alfa Romeo", Year = 2016},
                new Manufacturer {City = "UK", Name = "Aston Martin", Year = 2018},
                new Manufacturer {City = "USA", Name = "Dodge", Year = 2017},
                new Manufacturer {City = "Japan", Name = "Subaru", Year = 2016},
                new Manufacturer {City = "Germany", Name = "BMW", Year = 2015}
            };


    }

    public class JsonConverter
    {
        private readonly IEnumerable<Manufacturer> _manufacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {
            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);
            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }




    /// <summary>
    /// Adaptee
    /// </summary>
    public class XmlConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Manufacturers");
            var xAttributes = ManufacturerDataProvider.GetData()
                .Select(m => new XElement("Manufacturer",
                    new XAttribute("City", m.City),
                    new XAttribute("Name", m.Name),
                    new XAttribute("Year", m.Year)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            Console.WriteLine(xDocument);

            return xDocument;
        }
    }




    /// <summary>
    /// Target
    /// </summary>
    public interface IXmlToJson
    {
        void ConvertXmlToJson();
    }


    /// <summary>
    /// Adapter
    /// </summary>
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var manufacturers = _xmlConverter.GetXml()
                .Element("Manufacturers")
                ?.Elements("Manufacturer")
                .Select(m => new Manufacturer
                {
                    City = m.Attribute("City")?.Value,
                    Name = m.Attribute("Name")?.Value,
                    Year = Convert.ToInt32(m.Attribute("Year")?.Value)
                });

            new JsonConverter(manufacturers)
                .ConvertToJson();
        }



    }



}
