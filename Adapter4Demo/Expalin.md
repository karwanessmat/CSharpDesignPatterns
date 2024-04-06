

# Adapter Pattern Demonstration

This README outlines the process and code necessary to implement the Adapter Pattern in a sample application that converts XML data to JSON format.

## Step 1: Define the Target Interface

```csharp
namespace Adapter4Demo.Step1___Interface;

/// <summary>
/// Target
/// </summary>
public interface IXmlToJson
{
    void ConvertXmlToJson();
}
```

The `IXmlToJson` interface defines the method signature for converting XML to JSON.

## Step 2: Create the Adapter Class

```csharp
using System;
using System.Linq;
using Adapter4Demo.Step1___Interface;
using Adapter4Demo.Step3_Client___Adaptee;

namespace Adapter4Demo.step2_Adapter_Class;

/// <summary>
/// Adapter
/// </summary>
public class XmlToJsonAdapter : IXmlToJson
{
    private XmlConverter _xmlConverter;

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

        var data = new JsonConverter(manufacturers);
        data.ConvertToJson();
    }
}
```

The `XmlToJsonAdapter` class implements the `IXmlToJson` interface and defines the conversion logic from XML to JSON format.

## Step 3: The Adaptee Class

```csharp
using System;
using System.Linq;
using System.Xml.Linq;

namespace Adapter4Demo.Step3_Client___Adaptee;

/// <summary>
/// Adaptee
/// </summary>
public class XmlConverter
{
    public XDocument GetXml()
    {
        // Implementation of XML fetching logic
    }
}
```

The `XmlConverter` class is the Adaptee in our scenario. It has the method `GetXml` which retrieves XML data.

## Step 4: JSON Conversion Helper

```csharp
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Adapter4Demo;

public class JsonConverter
{
    private IEnumerable<Manufacturer> _manufacturers;

    public JsonConverter(IEnumerable<Manufacturer> manufacturers)
    {
        _manufacturers = manufacturers;
    }

    public void ConvertToJson()
    {
        // JSON conversion logic
    }
}
```

The `JsonConverter` class is a helper class that takes in a collection of `Manufacturer` objects and converts them to JSON.

## Step 5: Manufacturer Data Model

```csharp
namespace Adapter4Demo;

public class Manufacturer
{
    // Properties for Manufacturer
}
```

The `Manufacturer` class represents the data model that we want to convert from XML to JSON.

## Step 6: Data Provider Class

```csharp
namespace Adapter4Demo;

public static class ManufacturerDataProvider
{
    // Method to get dummy data
}
```

The `ManufacturerDataProvider` class provides sample data for the conversion process.

## Step 7: Client Usage

Finally, we use the adapter pattern in a client application as follows:

```csharp
var xmlConverter = new XmlConverter();
var adapter = new XmlToJsonAdapter(xmlConverter);
adapter.ConvertXmlToJson();
```

Here, we instantiate `XmlConverter`, create an `XmlToJsonAdapter` passing it to the converter, and then perform the conversion by calling `ConvertXmlToJson` method on the adapter.
```

