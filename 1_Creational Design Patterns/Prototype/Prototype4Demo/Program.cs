using Prototype4Demo.Step2_ConcretePrototypes;

var prototypeProduct = new Product("Basic T-Shirt", 19.99m, "A plain t-shirt", "/images/tshirt.png");

// Clone the prototype and update the properties for a new product variation
var redTShirt = (Product)prototypeProduct.Clone();
redTShirt.Name="Red T-Shirt";
redTShirt.ImageUrl = "/images/red-tshirt.png";
Console.WriteLine($"{redTShirt.Name} - {redTShirt.Price} - {redTShirt.Description} - {redTShirt.ImageUrl}");


Console.WriteLine();
Console.WriteLine("Original");
Console.WriteLine($"{prototypeProduct.Name} - {prototypeProduct.Price} - {prototypeProduct.Description} - {prototypeProduct.ImageUrl}");

Console.WriteLine();

// Similarly, clone the prototype for another product variation
var blueTShirt = (Product)prototypeProduct.Clone();
blueTShirt.Name = "Blue T-Shirt";
blueTShirt.ImageUrl = "/images/blue-tshirt.png";
Console.WriteLine($"{blueTShirt.Name} - {blueTShirt.Price} - {blueTShirt.Description} - {blueTShirt.ImageUrl}");
Console.WriteLine();
Console.WriteLine("Original");
Console.WriteLine($"{prototypeProduct.Name} - {prototypeProduct.Price} - {prototypeProduct.Description} - {prototypeProduct.ImageUrl}");


