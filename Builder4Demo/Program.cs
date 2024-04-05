using Builder4Demo;
using Builder4Demo.Step1___Production;
using Builder4Demo.Step3___Concrete_Builder;
using Builder4Demo.Step4___Directors;

var director = new CarDirector();

var carBuilder = new CarBuilder();
director.ConstructSportsCar(carBuilder);
var car = carBuilder.GetCarProduct();
Console.WriteLine(car);
Console.WriteLine("");

var manualCarBuilder =new CarManualBuilder();
director.ConstructSportsCar(manualCarBuilder);
var manualCar = manualCarBuilder.GetProduct();
Console.WriteLine(manualCar);

Console.WriteLine("_____________________________________________");
Console.WriteLine();

Application app = new Application();
Car sportCar = app.MakeCar(CarType.SportsCar);
Console.WriteLine(CarType.SportsCar.ToString());
Console.WriteLine(sportCar);
Console.WriteLine();
Manual carManual = app.MakeManual(CarType.SportsCar);
Console.WriteLine(carManual);

Console.ReadKey();