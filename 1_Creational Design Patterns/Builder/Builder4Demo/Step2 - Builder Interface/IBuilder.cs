using Builder4Demo.Step1___Production;

namespace Builder4Demo.Step2___Builder_Interface
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine(Engine  engine);
        void SetTripComputer(bool hasTripComputer);
        void SetGps(bool hasGps);

    }
}
