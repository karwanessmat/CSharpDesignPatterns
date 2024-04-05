using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder4Demo.Step1___Production;
using Builder4Demo.Step3___Concrete_Builder;
using Builder4Demo.Step4___Directors;

namespace Builder4Demo
{
    public class Application
    {
        private readonly CarDirector _carDirector = new();
        private readonly CarManualDirector _carManualDirector = new();

        public Car MakeCar(CarType carType)
        {
            var carBuilder = new CarBuilder();
            switch (carType)
            {
                case CarType.SportsCar:
                    _carDirector.ConstructSportsCar(carBuilder);
                    break;
                case CarType.SUV:
                    _carDirector.ConstructSUV(carBuilder);
                    break;
                case CarType.Sedan:
                    _carDirector.ConstructSedan(carBuilder);
                    break;
                case CarType.Convertible:
                    _carDirector.ConstructConvertible(carBuilder);
                    break;
                case CarType.Hatchback:
                    _carDirector.ConstructHatchback(carBuilder);
                    break;
                case CarType.PickupTruck:
                    _carDirector.ConstructPickupTruck(carBuilder);
                    break;
                default:
                    throw new ArgumentException("Invalid car type.");
            }

            return carBuilder.GetCarProduct();
        }


        public Manual MakeManual(CarType carType)
        {
            var manualBuilder = new CarManualBuilder();
            switch (carType)
            {
                case CarType.SportsCar:
                    _carManualDirector.ConstructSportsCarManual(manualBuilder);
                    break;
                case CarType.SUV:
                    _carManualDirector.ConstructSUVManual(manualBuilder);
                    break;
                case CarType.Sedan:
                    _carManualDirector.ConstructSedanManual(manualBuilder);
                    break;
                case CarType.Convertible:
                    _carManualDirector.ConstructConvertibleManual(manualBuilder);
                    break;
                case CarType.Hatchback:
                    _carManualDirector.ConstructHatchbackManual(manualBuilder);
                    break;
                case CarType.PickupTruck:
                    _carManualDirector.ConstructPickupTruckManual(manualBuilder);
                    break;
                default:
                    throw new ArgumentException("Invalid car type.");
            }
            return manualBuilder.GetProduct();
        }
    }
}
