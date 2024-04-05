using Builder7Demo.Step1_Production;
using Builder7Demo.Step2___Builder_Interface;

namespace Builder7Demo.Step3___Concrete_Builder;

public class DailyReportBuilder : IFurnitureInventoryBuilder
{
    private InventoryReport _report;
    private readonly IEnumerable<FurnitureItem> _items;

    public DailyReportBuilder(IEnumerable<FurnitureItem> items)
    {
        Reset();
        _items = items;
    }
    public void Reset()
    {
        _report = new InventoryReport();
    }

    public IFurnitureInventoryBuilder AddTitle()
    {
        _report.TitleSection = "------- Daily Inventory Report -------\n\n";
        return this;
    }

    public IFurnitureInventoryBuilder AddDimensions()
    {
        _report.DimensionsSection = string.Join(Environment.NewLine, _items.Select(product =>
            $"Product: {product.Name} \nPrice: {product.Price} \n" +
            $"Height: {product.Height} x Width: {product.Width} -> Weight: {product.Weight} lbs \n"));

        return this;
    }

    public IFurnitureInventoryBuilder AddLogistics(DateTime dateTime)
    {
        _report.LogisticsSection = $"Report generated on {dateTime}";
        return this;
    }

    public InventoryReport GetDailyReport()
    {
        var finishedReport = _report;
        Reset();

        return finishedReport;
    }


}