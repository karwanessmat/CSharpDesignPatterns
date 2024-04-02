using Factory4Demo.Step1_Product;
using Factory4Demo.Step2_Concretes;
using Factory4Demo.Step3_Creator;

namespace Factory4Demo.step4_ConcreteCreator;

public class SeaLogisticProviderFactory:LogisticProviderFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}