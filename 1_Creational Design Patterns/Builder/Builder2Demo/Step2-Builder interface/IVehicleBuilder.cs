using Builder2Demo.step1_Product;

namespace Builder2Demo.Step2_Builder_interface
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetBody();
        void SetAccessories();

        Vehicle Vehicle();
    }
}
