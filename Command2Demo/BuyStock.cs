namespace Command2Demo
{

    // concrete classes
    public class BuyStock : IOrder
    {
        private readonly Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute(int value)
        {
            _abcStock.Buy(value);
        }
    }
}
