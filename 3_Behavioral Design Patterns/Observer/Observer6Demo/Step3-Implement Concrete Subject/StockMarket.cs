using Observer6Demo.Step2_Define_Subject_Interface_or_Abstract;

namespace Observer6Demo.Step3_Implement_Concrete_Subject;

public class StockMarket : AbstractStockMarket
{
    private Dictionary<string, double> stockList =
        new Dictionary<string, double>();

    public override void AddStock(string stockSymbol, double price)
    {
        stockList.Add(stockSymbol, price);
        if(price < 25)
        {
            NotifySystems(stockList);
        }               
    }

    public override void Update(string stockSymbol, double price)
    {               
        stockList[stockSymbol] = price;
        if (price < 25)
        {
            NotifySystems(stockList);
        }
    }
}