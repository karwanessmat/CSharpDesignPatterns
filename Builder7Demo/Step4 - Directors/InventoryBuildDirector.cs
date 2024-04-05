using Builder7Demo.Step2___Builder_Interface;

namespace Builder7Demo.Step4___Directors;

public class InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
{
    public void BuildCompleteReport()
    {
        concreteBuilder.AddTitle();
        concreteBuilder.AddDimensions();
        concreteBuilder.AddLogistics(DateTime.Now);
    }
}