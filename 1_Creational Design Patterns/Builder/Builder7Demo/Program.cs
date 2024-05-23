using Builder7Demo;
using Builder7Demo.Step1_Production;
using Builder7Demo.Step3___Concrete_Builder;
using Builder7Demo.Step4___Directors;

var items = new List<FurnitureItem>
{
    new("Sectional Couch", 55.5, 22.4, 78.6, 35.0),
    new ("Nightstand", 25.0, 12.4, 20.0, 10.0),
    new ("Dining Table", 105.0, 35.4, 100.6, 55.5),
};

var inventoryBuilder = new DailyReportBuilder(items);

//var director = new InventoryBuildDirector(inventoryBuilder);
//director.BuildCompleteReport();
//var directorReport = inventoryBuilder.GetDailyReport();
//Console.WriteLine(directorReport.Display());



InventoryReport? fluentReport = inventoryBuilder
    .AddTitle()
    .AddDimensions()
    .AddLogistics(DateTime.Now)
    .GetDailyReport();

Console.WriteLine(fluentReport.Display());
