

using Mediator7Demo._02_CreateConcreteMediator;
using Mediator7Demo._04_CreateConcreteComponents;

var networkMediator = new NetworkMediator();

var desktopComputer = new DesktopComputer("computer-1", networkMediator);
var server = new Server("server-1", networkMediator);

networkMediator.Register("computer-1", desktopComputer);
networkMediator.Register("server-1", server);

desktopComputer.SendCommand("server-1", "reboot");
server.SendCommand("computer-1", "trigger-updates");

Console.ReadKey();