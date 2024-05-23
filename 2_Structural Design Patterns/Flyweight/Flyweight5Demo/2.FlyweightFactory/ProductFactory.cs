using Flyweight5Demo._1.ConcreteFlyweight;

namespace Flyweight5Demo._2.FlyweightFactory;

public class ProductFactory
{
    private readonly Dictionary<string, ProductDescription> _descriptions = new();

    public ProductDescription GetProductDescription(string description, string specifications, List<string> reviews)
    {
        string? key = $"{description}_{specifications}";

        if (!_descriptions.TryGetValue(key, out ProductDescription? productDescription))
        {
            productDescription = new ProductDescription(description, specifications, reviews);
            _descriptions[key] = productDescription;
        }

        return productDescription;
    }
}
