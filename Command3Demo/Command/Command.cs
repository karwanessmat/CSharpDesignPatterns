using Command3Demo.Receiver;

namespace Command3Demo.Command
{
    public abstract class Command
    {
        protected SimpleCalculator Receiver;

        protected Command(SimpleCalculator receiver)
        {
            this.Receiver = receiver;
        }
        public abstract int Execute();
    }

    public enum CommandOption
    {
        Add, Subtract, Multiply, Divide
    }
}
