using Decorator7Demo._1_Component_Interface;
using Decorator7Demo._2_Create_a_Concrete_Component;
using Decorator7Demo._4_Create_Concrete_Decorator;

Car theCar = new CompactCar();
//Car theCar = new FullSizeCar();

// we are adding the features and for each feature the cost is increased.
theCar = new Navigation(theCar);
theCar = new Sunroof(theCar);
theCar = new LeatherSeats(theCar);
Console.WriteLine(theCar.GetDescription());
Console.WriteLine($"{theCar.GetCarPrice():C2}");