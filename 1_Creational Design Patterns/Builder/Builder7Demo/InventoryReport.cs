using System.Text;

namespace Builder7Demo;

public class InventoryReport(string titleSection="", string dimensionsSection = "", string logisticsSection = "")
{
    public string TitleSection = titleSection;
    public string DimensionsSection = dimensionsSection;
    public string LogisticsSection = logisticsSection;

    public string Display()
    {
        return new StringBuilder()
            .AppendLine(TitleSection)
            .AppendLine(DimensionsSection)
            .AppendLine(LogisticsSection)
            .ToString();
    }
}