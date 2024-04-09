namespace Command2Demo
{

    // concrete classes
    public class BuyStock(Stock abcStock) : IOrder
    {
        public void Execute(int value)
        {
            abcStock.Buy(value);
        }
    }
}
