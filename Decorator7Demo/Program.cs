using Decorator7Demo._1.Component;
using Decorator7Demo._2.ConcreteComponents;
using Decorator7Demo._4.ConcreteDecorators;

Car theCar = new CompactCar();
//Car theCar = new FullSizeCar();

theCar = new Navigation(theCar);
theCar = new Sunroof(theCar);
theCar = new LeatherSeats(theCar);
Console.WriteLine(theCar.GetDescription());
Console.WriteLine($"{theCar.GetCarPrice():C2}");