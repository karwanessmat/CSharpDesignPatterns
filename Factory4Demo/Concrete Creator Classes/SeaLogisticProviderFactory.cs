using Factory4Demo.Concrete_Products;
using Factory4Demo.Creator_Class;
using Factory4Demo.Product_Interface;

namespace Factory4Demo.Concrete_Creator_Classes;

public class SeaLogisticProviderFactory:LogisticProviderFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}