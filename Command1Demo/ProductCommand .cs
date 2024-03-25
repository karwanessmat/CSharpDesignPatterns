using Command1Demo.receiver;

namespace Command1Demo
{
    //public class ProductCommand : ICommand
    //{
    //    private readonly Product _product;
    //    private readonly PriceAction _priceAction;
    //    private readonly int _amount;

    //    public ProductCommand(Product product, PriceAction priceAction, int amount)
    //    {
    //        _product = product;
    //        _priceAction = priceAction;
    //        _amount = amount;
    //    }

    //    public void ExecuteAction()
    //    {
    //        if (_priceAction == PriceAction.Increase)
    //        {
    //            _product.IncreasePrice(_amount);
    //        }
    //        else
    //        {
    //            _product.DecreasePrice(_amount);

    //        }
    //    }


    //    public void UndoAction()
    //    {
    //        if (_priceAction == PriceAction.Increase)
    //        {
    //            _product.DecreasePrice(_amount);
    //        }
    //        else
    //        {
    //            _product.IncreasePrice(_amount);
    //        }
    //    }
    //}

    public class ProductCommand : ICommand
    {
        private readonly Product _product;
        private readonly PriceAction _priceAction;
        private readonly int _amount;

        public bool IsCommandExecuted { get; private set; }

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void ExecuteAction()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                IsCommandExecuted = true;
            }
            else
            {
                IsCommandExecuted = _product.DecreasePrice(_amount);
            }
        }

        public void UndoAction()
        {
            if (!IsCommandExecuted)
                return;

            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
            }
            else
            {
                _product.IncreasePrice(_amount);
            }
        }
    }

}
