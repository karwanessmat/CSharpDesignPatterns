using Builder5Demo.Step3___Concrete_Builder;
using Builder5Demo.Step4___Directors;


var carBuilder = new VehicleDirector(new CarBuilder());
var car = carBuilder.Construct();
Console.WriteLine(car);


Console.WriteLine();
var motorcycleBuilder = new VehicleDirector(new MotorcycleBuilder());
var motorcycle = motorcycleBuilder.Construct();
Console.WriteLine(motorcycle);


Console.WriteLine();
var scooterBuilder = new VehicleDirector(new ScooterBuilder());
var scooter = scooterBuilder.Construct();
Console.WriteLine(scooter);