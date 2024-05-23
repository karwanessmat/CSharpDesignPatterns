using Command3Demo._1.Command_Interface;
using Command3Demo._3.Receiver;

namespace Command3Demo._2.Concrete_Commands;

public class AddCommand(SimpleCalculator receiver) : Command(receiver)
{
    private readonly SimpleCalculator _calculator = receiver;

    public override int Execute()
    {
        return _calculator.Add();
    }
}