using Template4Demo.AbstractClass;
using Template4Demo.ConcreteClass;

VehicleAssembly vehicle;

Console.WriteLine("Assembling a car:");
vehicle = new CarAssembly();
vehicle.AssembleVehicle();

Console.WriteLine();
Console.WriteLine("\nAssembling a motorcycle:");
vehicle = new MotorcycleAssembly();
vehicle.AssembleVehicle();