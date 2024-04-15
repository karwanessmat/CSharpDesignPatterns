using Factory4Demo.Step1_Product_Interface;
using Factory4Demo.Step2_Product_Concretes;
using Factory4Demo.Step3_Creator;

namespace Factory4Demo.step4_Concrete_Creator;

/// <summary>
/// Create subclasses of the creator class. Each subclass should override the
/// factory method to instantiate and return its specific version of the product.
/// </summary>
public class AirLogisticProviderFactory:LogisticProviderFactory
{
    public override ITransport CreateTransport()
    {
        return new Air();
    }
}