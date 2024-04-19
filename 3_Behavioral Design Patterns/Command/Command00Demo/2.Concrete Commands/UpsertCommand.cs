using Command00Demo._1.Command_Interface;
using Command00Demo._3.Receiver;

namespace Command00Demo._2.Concrete_Commands;

internal class UpsertCommand(
    string key,
    string value,
    DataReceiver receiver) : Command(receiver)
{
    public override void Execute()
    {
        Receiver.Upsert(key, value);
    }
}