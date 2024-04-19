using Command4Demo._1.Command_Interface;
using Command4Demo._3.Receiver.Repositories;

namespace Command4Demo._2.Concrete_Commands;
public class ChangeQuantityCommand(
    Operation operation,
    IShoppingCartRepository shoppingCartRepository,
    IProductRepository productRepository,
    Product product)
    : ICommand
{
    public void Execute()
    {
        switch (operation)
        {
            case Operation.Decrease:
                productRepository.IncreaseStockBy(product.ArticleId, 1);
                shoppingCartRepository.DecreaseQuantity(product.ArticleId);
                break;
            case Operation.Increase:
                productRepository.DecreaseStockBy(product.ArticleId, 1);
                shoppingCartRepository.IncreaseQuantity(product.ArticleId);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public bool CanExecute()
    {
        return operation switch
        {
            Operation.Decrease => shoppingCartRepository.Get(product.ArticleId).Quantity != 0,
            Operation.Increase => shoppingCartRepository.Get(product.ArticleId).Quantity >= 0,
            _ => false
        };
    }

    public void Undo()
    {
        switch (operation)
        {
            case Operation.Decrease:
                productRepository.DecreaseStockBy(product.ArticleId, 1);
                shoppingCartRepository.IncreaseQuantity(product.ArticleId);

                break;
            case Operation.Increase:
                productRepository.IncreaseStockBy(product.ArticleId, 1);
                shoppingCartRepository.DecreaseQuantity(product.ArticleId);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

