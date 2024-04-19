using Mediator5Demo._02_CreateConcreteMediator;
using Mediator5Demo._04_CreateConcreteComponents;

var teamChat = new TeamChatroom();

var karwan = new Developer("Karwan");
var steve = new Developer("Steve");
var justin = new Developer("Justin");
var jenna = new Developer("Jenna");
var kim = new Tester("Kim");
var julia = new Tester("Julia");

teamChat.RegisterMembers(karwan, steve, justin, jenna, kim, julia);

steve.Send("Hey everyone, we're going to be deploying at 2pm today.");
Console.WriteLine();
Console.WriteLine();
kim.Send("Ok, thanks for letting us know.");

Console.WriteLine();
