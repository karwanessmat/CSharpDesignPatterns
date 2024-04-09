using Command3Demo.Receiver;

namespace Command3Demo.ConcreteCommandClasses
{
    public class AddCommand(SimpleCalculator receiver) : Command.Command(receiver)
    {
        private readonly SimpleCalculator _calculator = receiver;

        public override int Execute()
        {
            return _calculator.Add();
        }
    }
}
