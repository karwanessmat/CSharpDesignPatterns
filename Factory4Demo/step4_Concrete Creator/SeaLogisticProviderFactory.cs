using Factory4Demo.Step1_Product_Interface;
using Factory4Demo.Step2_Product_Concretes;
using Factory4Demo.Step3_Creator;

namespace Factory4Demo.step4_Concrete_Creator;

public class SeaLogisticProviderFactory:LogisticProviderFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}