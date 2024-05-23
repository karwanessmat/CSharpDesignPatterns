using Command1Demo._1.Command_Interface;
using Command1Demo._3.Receiver;

namespace Command1Demo._2.Concrete_Commands;

public class ProductCommand(Product product, PriceAction priceAction, int amount) : ICommand
{
    public bool IsCommandExecuted { get; private set; }

    public void ExecuteAction()
    {
        if (priceAction == PriceAction.Increase)
        {
            product.IncreasePrice(amount);
            IsCommandExecuted = true;
        }
        else
        {
            IsCommandExecuted = product.DecreasePrice(amount);
        }
    }

    public void UndoAction()
    {
        if (!IsCommandExecuted)
            return;

        if (priceAction == PriceAction.Increase)
        {
            product.DecreasePrice(amount);
        }
        else
        {
            product.IncreasePrice(amount);
        }
    }
}