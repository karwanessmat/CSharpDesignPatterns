using Observer0Demo.Step3_Implement_Concrete_Subject;
using Observer0Demo.Step4_Implement_Concrete_Observers;

var publisher = new Publisher("Message Hub");

var subscriber1 = new Subscriber("First Subscriber");
var subscriber2 = new Subscriber("Second Subscriber");
var subscriber3 = new Subscriber("Third Subscriber");

Console.WriteLine("Adding the first and the second subscribers to the publisher.");
publisher.Subscribe(subscriber1);
publisher.Subscribe(subscriber2);

Console.WriteLine("Notifying subscribers.");
publisher.Notify("Sequence initiated.");

Console.WriteLine("Removing the first subscriber.");
publisher.Unsubscribe(subscriber1);

Console.WriteLine("Adding the third subscriber.");
publisher.Subscribe(subscriber3);

Console.WriteLine("Notifying subscribers.");
publisher.Notify("Update received from the server.");

Console.ReadKey();