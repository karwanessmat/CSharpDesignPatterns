using Observer6Demo.Step3_Implement_Concrete_Subject;
using Observer6Demo.Step4_Implement_Concrete_Observers;

var market = new StockMarket();
var push = new PushNotification();
var email = new EmailNotification();

market.AddSystem(push);
market.AddSystem(email);



market.AddStock("MSFT", 100);
market.AddStock("GOOGL", 190);


Console.WriteLine("===== Updating MSFT =====");
market.Update("MSFT", 21.99);

Console.WriteLine("===== Updating GOOGL =====");
market.Update("GOOGL", 44.68);