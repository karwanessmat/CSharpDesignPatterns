using Command4Demo._1.Command_Interface;
using Command4Demo.Repositories;

namespace Command4Demo._2.Concrete_Commands
{
    public class AddToCardCommand(
        IShoppingCartRepository shoppingCartRepository,
        IProductRepository productRepository,
        Product product)
        : ICommand
    {
        

        public void Execute()
        {
            if (product is null)
            {
                return;
            }

            productRepository.DecreaseStockBy(product.ArticleId, 1);
            shoppingCartRepository.Add(product);
        }

        public bool CanExecute()
        {
            return productRepository.GetStockFor(product.ArticleId) > 0;
        }

        public void Undo()
        {
            if (product is null)
            {
                return;
            }

            var lineItem = shoppingCartRepository.Get(product.ArticleId);
            productRepository.IncreaseStockBy(product.ArticleId,lineItem.Quantity);
            shoppingCartRepository.RemoveAll(product.ArticleId);
        }
    }
}
