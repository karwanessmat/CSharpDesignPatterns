using Flyweight5Demo._1.ConcreteFlyweight;

namespace Flyweight5Demo._3.Context;

public class Product(string sku, decimal price, int quantityInStock, ProductDescription description)
{
    public string SKU { get; } = sku;
    public decimal Price { get; set; } = price;
    public int QuantityInStock { get; set; } = quantityInStock;

    public void DisplayProduct()
    {
        Console.WriteLine($"SKU: {SKU}, Price: {Price}, In Stock: {QuantityInStock}");
        Console.WriteLine($"Description: {description.Description}");
        Console.WriteLine($"Specifications: {description.Specifications}");
        Console.WriteLine($"Reviews: {string.Join(", ", description.Reviews)}");
    }
}
