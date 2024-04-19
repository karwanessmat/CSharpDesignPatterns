


using Command00Demo._2.Concrete_Commands;
using Command00Demo._3.Receiver;
using Command00Demo._4.Invoker;

var dataReceiver = new DataReceiver();
var invoker = new DataCommandInvoker();
invoker.SetCommand(new UpsertCommand("item1", "value1", dataReceiver));
invoker.ExecuteCommand();

invoker.SetCommand(new UpsertCommand("item2", "value1", dataReceiver));
invoker.ExecuteCommand();

invoker.SetCommand(new UpsertCommand("item1", "value1Updated", dataReceiver));
invoker.ExecuteCommand();

invoker.SetCommand(new DeleteCommand("item1", dataReceiver));
invoker.ExecuteCommand();
Console.ReadKey();


