using Command4Demo.Repositories;
using Command4Demo._1.Command_Interface;

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

        var lineItem = shoppingCartRepository.Get(product.ArticleId);

        productRepository.IncreaseStockBy(product.ArticleId, lineItem.Quantity);

        shoppingCartRepository.RemoveAll(product.ArticleId);
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}