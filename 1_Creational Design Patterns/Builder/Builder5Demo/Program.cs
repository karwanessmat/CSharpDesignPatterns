using Builder5Demo.Step1_Production;
using Builder5Demo.Step3___Concrete_Builder;
using Builder5Demo.Step4___Directors;


var carBuilder = new VehicleDirector(new CarBuilder());
Vehicle? car = carBuilder.Construct();
Console.WriteLine(car);


Console.WriteLine();
var motorcycleBuilder = new VehicleDirector(new MotorcycleBuilder());
Vehicle? motorcycle = motorcycleBuilder.Construct();
Console.WriteLine(motorcycle);


Console.WriteLine();
var scooterBuilder = new VehicleDirector(new ScooterBuilder());
Vehicle? scooter = scooterBuilder.Construct();
Console.WriteLine(scooter);