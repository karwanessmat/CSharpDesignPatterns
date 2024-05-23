using Observer6Demo.Step1_Define_Observer_Interface;

namespace Observer6Demo.Step2_Define_Subject_Interface_or_Abstract;

public abstract class AbstractStockMarket
{
    private readonly List<INotifier> _notificationSystems = [];

    public void AddSystem(INotifier notifier)
    {
        _notificationSystems.Add(notifier);
    }

    public void NotifySystems(Dictionary<string,double> stockList)
    {
        foreach (INotifier notifier in _notificationSystems)
        {
            notifier.Notify(stockList);
        }
    }

    public abstract void AddStock(string stockSymbol, double price);

    public abstract void Update(string stockSymbol, double price);
}