using Builder4Demo.Step1___Production;
using Builder4Demo.Step2___Builder_Interface;

namespace Builder4Demo.Step3___Concrete_Builder
{
    internal class CarBuilder:IBuilder
    {
        private  Car _car = new();

        public CarBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            _car = new Car();
        }

        public void SetSeats(int number)
        {
            _car.Seats = number;
        }

        public void SetEngine(Engine engine)
        {
            _car.Engine = engine;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _car.HasTripComputer = hasTripComputer;
        }

        public void SetGps(bool hasGps)
        {
            _car.HasGPS = hasGps;
        }


        // we do not definition inside IBuilder because we have another type such as (Manual) to return.
        public Car GetCarProduct()
        {
            var product = _car;
            Reset();
            return product;
        }
    }
}
