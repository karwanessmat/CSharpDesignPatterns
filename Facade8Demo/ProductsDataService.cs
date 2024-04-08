namespace Facade8Demo;

internal class ProductsDataService
{
    private readonly Dictionary<int, List<Product>> _productLists = new()
    {
        [1] = [
            new Product("Product 1", 9.99),
            new Product("Product 2", 19.99)
              ],
        [2] =
            [
            new Product("Bundle 1", 99.99),
            new Product("Bundle 2", 199.99)
            ]
    };

    public List<Product> GetProductsForCategory(int categoryId)
    {
        return _productLists[categoryId];
    }
}