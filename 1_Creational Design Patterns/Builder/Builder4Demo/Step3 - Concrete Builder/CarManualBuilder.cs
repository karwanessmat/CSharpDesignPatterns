using Builder4Demo.Step1___Production;
using Builder4Demo.Step2___Builder_Interface;

namespace Builder4Demo.Step3___Concrete_Builder
{
    public class CarManualBuilder:IBuilder
    {
        private Manual _manual = new Manual();

        public CarManualBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetSeats(int number)
        {
            _manual.Seats = number;
        }

        public void SetEngine(Engine engine)
        {
            _manual.EngineInstructions = engine.ToString();
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _manual.TripComputerInstructions = hasTripComputer 
                ? "The car has a trip computer." 
                : "The car does not have a trip computer.";
        }

        public void SetGps(bool hasGps)
        {
            _manual.GPSInstructions = hasGps
                ? "The car has a GPS"
                : "The car does not have a trip computer";
        }

        public Manual GetProduct()
        {
            var product = _manual;
            Reset();
            return product;
        }
    }
}
