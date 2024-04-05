using Builder5Demo.Step3___Concrete_Builder;
using Builder5Demo.Step4___Directors;

var director = new VehicleDirector();

var carBuilder = new CarBuilder();
var car = director.Construct(carBuilder);
Console.WriteLine(car);


Console.WriteLine();
var motorcycleBuilder = new MotorcycleBuilder();
var motorcycle = director.Construct(motorcycleBuilder);
Console.WriteLine(motorcycle);


Console.WriteLine();
var scooterBuilder = new ScooterBuilder();
var scooter = director.Construct(scooterBuilder);
Console.WriteLine(scooter);