using Builder4Demo.Step1___Production;
using Builder4Demo.Step2___Builder_Interface;

namespace Builder4Demo.Step4___Directors;

public class CarManualDirector
{
    public void ConstructSportsCarManual( IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine(new Engine("Sport", 500));
        builder.SetTripComputer(true);
        builder.SetGps(true);
    }

    public void ConstructSUVManual(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine(new Engine("SUV", 350));
        builder.SetTripComputer(true);
        builder.SetGps(true);
    }

    public void ConstructSedanManual(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine(new Engine("Sedan", 250));
        builder.SetTripComputer(false);
        builder.SetGps(false);
    }

    public void ConstructConvertibleManual(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(4);
        builder.SetEngine(new Engine("Convertible", 300));
        builder.SetTripComputer(true);
        builder.SetGps(true);
    }

    public void ConstructHatchbackManual(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(4);
        builder.SetEngine(new Engine("Hatchback", 200));
        builder.SetTripComputer(false);
        builder.SetGps(false);
    }

    public void ConstructPickupTruckManual(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(4);
        builder.SetEngine(new Engine("Pickup", 400));
        builder.SetTripComputer(true);
        builder.SetGps(true);
    }
}