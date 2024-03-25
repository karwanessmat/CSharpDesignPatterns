using Command3Demo.Receiver;

namespace Command3Demo.ConcreteCommandClasses
{
    public class SubtractCommand:Command.Command
    {
        private readonly SimpleCalculator _calculator;
        public SubtractCommand(SimpleCalculator receiver) : base(receiver)
        {
            _calculator = receiver;
        }

        public override int Execute()
        {
          return  _calculator.Subtract();
        }
    }
}
