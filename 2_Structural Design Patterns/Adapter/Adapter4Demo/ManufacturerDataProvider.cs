using System.Collections.Generic;

namespace Adapter4Demo;

public static class ManufacturerDataProvider
{
    public static List<Manufacturer> GetData() =>
    [
        new(){ City = "Italy", Name = "Alfa Romeo", Year = 2016 },
        new(){ City = "UK", Name = "Aston Martin", Year = 2018 },
        new(){ City = "USA", Name = "Dodge", Year = 2017 },
        new(){ City = "Japan", Name = "Subaru", Year = 2016 },
        new(){ City = "Germany", Name = "BMW", Year = 2015 }
    ];


}