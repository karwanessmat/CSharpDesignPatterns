namespace Command2Demo
{
    public class SellStock(Stock abcStock) : IOrder
    {
        public void Execute(int value)
    {
        abcStock.Sell(value);
    }
    }
}
