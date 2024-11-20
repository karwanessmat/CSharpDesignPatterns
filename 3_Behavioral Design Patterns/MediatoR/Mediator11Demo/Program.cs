using Mediator11Demo._02_CreateConcreteMediator;
using Mediator11Demo._04_CreateConcreteComponents;

var chatRoom = new ChatRoomMediator();

var alice = new ChatUser("Alice");
var bob = new ChatUser("Bob");
var charlie = new ChatUser("Charlie");

chatRoom.RegisterUser(alice);
chatRoom.RegisterUser(bob);
chatRoom.RegisterUser(charlie);

alice.SendMessage("Hi Bob!", "Bob");
bob.SendMessage("Hello Alice!", "Alice");
charlie.SendMessage("Hey everyone!", "Alice");
charlie.SendMessage("Hi Bob!", "Bob");