using Observer6Demo.Step2_Define_Subject_Interface_or_Abstract;

namespace Observer6Demo.Step3_Implement_Concrete_Subject;

public class StockMarket : AbstractStockMarket
{
    private readonly Dictionary<string, double> _stockList = new();

    public override void AddStock(string stockSymbol, double price)
    {
        _stockList.Add(stockSymbol, price);
        if(price < 25)
        {
            NotifySystems(_stockList);
        }               
    }

    public override void Update(string stockSymbol, double price)
    {               
        _stockList[stockSymbol] = price;
        if (price < 25)
        {
            NotifySystems(_stockList);
        }
    }
}