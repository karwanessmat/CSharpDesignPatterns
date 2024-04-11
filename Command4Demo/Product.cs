namespace Command4Demo;

public class Product(string articleId, string name, decimal price)
{
    public string ArticleId { get; set; } = articleId;
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
}
