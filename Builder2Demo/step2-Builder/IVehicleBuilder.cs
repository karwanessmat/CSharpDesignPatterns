using Builder2Demo.step1_Product;

namespace Builder2Demo.step2_Builder
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
