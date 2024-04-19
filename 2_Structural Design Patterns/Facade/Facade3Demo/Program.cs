using Facade3Demo;

var homeAutomation = new HomeAutomation();

// Simulating leaving the home
Console.WriteLine("Leaving the home...");
homeAutomation.DepartHome();

Console.WriteLine();

// Simulating arriving home
Console.WriteLine("Arriving home...");
homeAutomation.ArriveHome();