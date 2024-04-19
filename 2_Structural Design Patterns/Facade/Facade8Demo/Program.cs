using Facade8Demo;

var facade = new ProductsFacade();

foreach (var product in facade.GetProductListForAccount("John Smith"))
{
    Console.WriteLine($"Product name: {product.Name}");
    Console.WriteLine($"Product price: {product.Price}");
}

Console.ReadKey();