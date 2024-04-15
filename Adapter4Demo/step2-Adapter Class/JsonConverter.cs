﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Adapter4Demo;

public class JsonConverter(IEnumerable<Manufacturer> manufacturers)
{
    public void ConvertToJson()
    {
        var jsonManufacturers = JsonConvert.SerializeObject(manufacturers, Formatting.Indented);
        Console.WriteLine("\nPrinting JSON list\n");
        Console.WriteLine(jsonManufacturers);
    }
}