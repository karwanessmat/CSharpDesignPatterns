namespace Command4Demo._3.Receiver.Repositories;


public interface IShoppingCartRepository
{
    (Product Product, int Quantity) Get(string articleId);
    IEnumerable<(Product Product, int Quantity)> All();
    void Add(Product product);
    void RemoveAll(string articleId);
    void IncreaseQuantity(string articleId);
    void DecreaseQuantity(string articleId);
}