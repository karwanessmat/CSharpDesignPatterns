using Factory4Demo.Step1_Product;
using Factory4Demo.Step2_Concretes;
using Factory4Demo.Step3_Creator;

namespace Factory4Demo.step4_ConcreteCreator;
    /// <summary>
    /// Create subclasses of the creator class. Each subclass should override the
    /// factory method to instantiate and return its specific version of the product.
    /// </summary>
    public class RoadLogisticProviderFactory:LogisticProviderFactory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }

