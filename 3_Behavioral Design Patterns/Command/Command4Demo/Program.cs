

using Command4Demo;
using Command4Demo._2.Concrete_Commands;
using Command4Demo._3.Receiver.Repositories;
using Command4Demo._4.Invoker;

var shoppingCartRepository = new ShoppingCartRepository();
var productsRepository = new ProductsRepository();

var product = productsRepository.FindBy("4");

var addToCartCommand = new AddToCardCommand(shoppingCartRepository,
    productsRepository,
    product);

var increaseQuantityCommand = new ChangeQuantityCommand(
    Operation.Increase,
    shoppingCartRepository,
    productsRepository,
    product);

var manager = new CommandManager();
manager.Invoke(addToCartCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);

PrintCart(shoppingCartRepository);

manager.Undo();

PrintCart(shoppingCartRepository);
return;


static void PrintCart(ShoppingCartRepository shoppingCartRepository)
{
    var totalPrice = 0m;
    foreach (var lineItem in shoppingCartRepository.LineItems)
    {
        var price = lineItem.Value.Product.Price * lineItem.Value.Quantity;

        Console.WriteLine($"{lineItem.Key} " +
                          $"${lineItem.Value.Product.Price} x {lineItem.Value.Quantity} = ${price}");

        totalPrice += price;
    }

    Console.WriteLine($"Total price:\t${totalPrice}");
}