namespace Builder7Demo.Step2___Builder_Interface;

public interface IFurnitureInventoryBuilder
{
    IFurnitureInventoryBuilder AddTitle();
    IFurnitureInventoryBuilder AddDimensions();
    IFurnitureInventoryBuilder AddLogistics(DateTime dateTime);
    InventoryReport GetDailyReport();
}