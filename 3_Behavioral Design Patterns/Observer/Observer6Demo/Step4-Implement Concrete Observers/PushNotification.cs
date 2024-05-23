using Observer6Demo.Step1_Define_Observer_Interface;

namespace Observer6Demo.Step4_Implement_Concrete_Observers;

public class PushNotification : INotifier
{
    public void Notify(Dictionary<string, double> stockList)
    {
        Console.WriteLine("Push Notification: Opportunity to buy!");
        foreach (var stock in stockList)
        {
            Console.WriteLine($"{stock.Key} - {stock.Value}");
        }
    }
}