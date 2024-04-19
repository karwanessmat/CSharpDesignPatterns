using Prototype6Demo.Step2_ConcretePrototypes;

var object1 = new CloneableObject("Title 1");
Console.WriteLine($"Object 1 title {object1.InternalTitle}");
Console.WriteLine($"Object 1 data {object1.Data}");
Console.WriteLine();
var object2=(CloneableObject) object1.Clone();
Console.WriteLine($"Object 2 title {object2.InternalTitle}");
Console.WriteLine($"Object 2 data {object2.Data}");
