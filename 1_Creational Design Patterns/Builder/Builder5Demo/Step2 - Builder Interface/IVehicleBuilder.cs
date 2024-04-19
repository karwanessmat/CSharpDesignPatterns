using Builder5Demo.Step1_Production;

namespace Builder5Demo.Step2___Builder_Interface
{
    public interface IVehicleBuilder
    {
        void SetType();
        void SetWheels();
        void SetEngine();
        void SetColor();
        Vehicle Build();
    }
}
