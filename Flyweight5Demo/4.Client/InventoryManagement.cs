using Flyweight5Demo._2.FlyweightFactory;
using Flyweight5Demo._3.Context;

namespace Flyweight5Demo._4.Client;

public class InventoryManagement
{
    private readonly ProductFactory _productFactory = new();
    private readonly List<Product> _products = new();

    public void AddProduct(string sku, decimal price, int quantityInStock, string description, string specifications, List<string> reviews)
    {
        var productDescription = _productFactory.GetProductDescription(description, specifications, reviews);
        var product = new Product(sku, price, quantityInStock, productDescription);
        _products.Add(product);
    }

    public void DisplayInventory()
    {
        foreach (var product in _products)
        {
            product.DisplayProduct();
            Console.WriteLine();
        }
    }
}
