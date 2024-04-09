using Command3Demo.Receiver;

namespace Command3Demo.Command
{
    public abstract class Command(SimpleCalculator receiver)
    {
        protected SimpleCalculator Receiver = receiver;

        public abstract int Execute();
    }

    public enum CommandOption
    {
        Add, Subtract, Multiply, Divide
    }
}
