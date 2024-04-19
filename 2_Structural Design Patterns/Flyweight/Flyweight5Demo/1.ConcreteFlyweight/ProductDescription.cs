namespace Flyweight5Demo._1.ConcreteFlyweight;
/// <summary>
/// Step 1: ProductDescription (ConcreteFlyweight)
///The ProductDescription class will hold the large shared data - the description, reviews, and specifications
/// that are common for all instances of the same product.
/// </summary>
public class ProductDescription(string description, string specifications, List<string> reviews)
{
    public string Description { get; } = description;
    public string Specifications { get; } = specifications;
    public List<string> Reviews { get; } = new List<string>(reviews);
}
