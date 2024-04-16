using Facade5Demo;
using Facade5Demo.Services;

IServiceFacade facade = new ServiceFacade();

Tuple<int, double, string> result = facade.CallFacade();

Console.WriteLine(result.Item1 + " - " + result.Item2 + " - " + result.Item3);