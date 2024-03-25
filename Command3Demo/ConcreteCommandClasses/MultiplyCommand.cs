using Command3Demo.Receiver;

namespace Command3Demo.ConcreteCommandClasses
{
    public class MultiplyCommand:Command.Command
    {
        private readonly SimpleCalculator _calculator;

        public MultiplyCommand(SimpleCalculator receiver) : base(receiver)
        {
            _calculator = receiver;
        }

        public override int Execute()
        {
            return _calculator.Multiply();
        }
    }
}
