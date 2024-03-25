using Builder2Demo.Product;

namespace Builder2Demo.Builder
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
