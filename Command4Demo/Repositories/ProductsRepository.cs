namespace Command4Demo.Repositories;


public class ProductsRepository : IProductRepository
{
    private Dictionary<string, (Product Product, int Stock)> Products { get; }

    public ProductsRepository()
    {
        Products = [];

        AddProduct(new Product("1", "Canon EOS R", 1099), 2);
        AddProduct(new Product("2", "Canon EOS 70D", 699), 1);
        AddProduct(new Product("3", "Atomos Ninja V", 799), 0);
        AddProduct(new Product("4", "Shure SM7B", 399), 5);
    }

    public void AddProduct(Product product, int stock)
    {
        Products[product.ArticleId] = (product, stock);
    }

    public void DecreaseStockBy(string articleId, int amount)
    {
        if (!Products.ContainsKey(articleId)) return;

        Products[articleId] = (Products[articleId].Product, Products[articleId].Stock - amount);
    }

    public void IncreaseStockBy(string articleId, int amount)
    {
        if (!Products.ContainsKey(articleId)) return;

        Products[articleId] =
            (Products[articleId].Product, Products[articleId].Stock + amount);
    }

    public IEnumerable<Product> All()
    {
        return Products.Select(x => x.Value.Product);
    }

    public int GetStockFor(string articleId)
    {
        if (Products.ContainsKey(articleId))
        {
            return Products[articleId].Stock;
        }

        return 0;
    }

    public Product FindBy(string articleId)
    {
        if (Products.TryGetValue(articleId, out var product))
        {
            return product.Product;
        }

        return null;
    }
}