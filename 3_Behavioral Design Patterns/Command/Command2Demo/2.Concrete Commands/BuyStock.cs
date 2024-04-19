using Command2Demo._1.Command_Interface;
using Command2Demo._3.Receiver;

namespace Command2Demo._2.Concrete_Commands
{

    //
    /// <summary>
    ///  concrete classes
    /// Stock is a Receiver
    /// </summary>
    /// <param name="abcStock"></param>
    public class BuyStock(Stock abcStock) : IOrder
    {
        public void Execute(int value)
        {
            abcStock.Buy(value);
        }
    }
}
