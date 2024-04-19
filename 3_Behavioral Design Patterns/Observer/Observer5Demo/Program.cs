using Observer5Demo.Step3_Implement_Concrete_Subject;
using Observer5Demo.Step4_Implement_Concrete_Observers;

var gClooney = new GClooney("I love my new wife");
var tSwift = new Swift("1981 is now my favorite number.");

var firstFan = new Fan();
var secondFan = new Fan();

gClooney.AddFollower(firstFan);
tSwift.AddFollower(secondFan);

gClooney.Tweet = "My wife didn't force me to tweet.";
tSwift.Tweet = "I love my new music.";

Console.Read();