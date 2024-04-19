using Command3Demo._3.Receiver;

namespace Command3Demo._1.Command_Interface
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
