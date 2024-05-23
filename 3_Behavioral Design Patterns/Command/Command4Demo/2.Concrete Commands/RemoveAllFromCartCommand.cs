using Command4Demo._1.Command_Interface;
using Command4Demo._3.Receiver.Repositories;

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
        (Product Product, int Quantity)[]? items = shoppingCartRepository.All().ToArray(); // Make a local copy

        foreach ((Product Product, int Quantity) lineItem in items)
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