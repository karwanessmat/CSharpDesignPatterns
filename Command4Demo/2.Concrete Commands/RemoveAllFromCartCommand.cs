using Command4Demo.Repositories;
using Command4Demo._1.Command_Interface;

namespace Command4Demo._2.Concrete_Commands;

public class RemoveAllFromCartCommand(
    IShoppingCartRepository shoppingCartRepository,
    IProductRepository productRepository)
    : ICommand
{
    public bool CanExecute()
    {
        return shoppingCartRepository.All().Any();
    }

    public void Execute()
    {
        var items = shoppingCartRepository.All().ToArray(); // Make a local copy

        foreach (var lineItem in items)
        {
            productRepository.IncreaseStockBy(lineItem.Product.ArticleId, lineItem.Quantity);

            shoppingCartRepository.RemoveAll(lineItem.Product.ArticleId);
        }
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}