using Command4Demo._1.Command_Interface;
using Command4Demo._3.Receiver.Repositories;

namespace Command4Demo._2.Concrete_Commands;

public class RemoveFromCartCommand(
    IShoppingCartRepository shoppingCartRepository,
    IProductRepository productRepository,
    Product product)
    : ICommand
{
    public bool CanExecute()
    {
        if (product == null) return false;

        return shoppingCartRepository.Get(product.ArticleId).Quantity > 0;
    }

    public void Execute()
    {
        if (product == null) return;

        (Product Product, int Quantity) lineItem = shoppingCartRepository.Get(product.ArticleId);

        productRepository.IncreaseStockBy(product.ArticleId, lineItem.Quantity);

        shoppingCartRepository.RemoveAll(product.ArticleId);
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}