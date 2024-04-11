using Command00Demo._3.Receiver;

namespace Command00Demo._1.Command_Interface;

internal abstract class Command(DataReceiver receiver) : ICommand
{
    protected DataReceiver Receiver = receiver;

    public abstract void Execute();
}