using Proxy8Demo;

var dataService = new DataServiceProxy();
dataService.InsertData("item 1");
dataService.InsertData("item 2");
dataService.InsertData("item 3");

var data = await dataService.GetData();
Console.WriteLine($"Items retrieved: {data.Count}");
data = await dataService.GetData();
Console.WriteLine($"Items retrieved: {data.Count}");

Console.ReadKey();
