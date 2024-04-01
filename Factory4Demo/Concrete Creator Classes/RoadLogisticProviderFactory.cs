using Factory4Demo.Concrete_Products;
using Factory4Demo.Creator_Class;
using Factory4Demo.Product_Interface;

namespace Factory4Demo.Concrete_Creator_Classes;
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

