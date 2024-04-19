using Command00Demo._1.Command_Interface;
using Command00Demo._3.Receiver;

namespace Command00Demo._2.Concrete_Commands;

internal class DeleteCommand(string key,DataReceiver receiver) : Command(receiver)
{
    public override void Execute()
    {
        Receiver.Delete(key);
    }
}