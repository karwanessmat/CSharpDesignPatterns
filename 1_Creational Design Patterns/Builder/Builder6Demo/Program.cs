using Builder6Demo.Step1_Production;
using Builder6Demo.Step3___Concrete_Builder;
using Builder6Demo.Step4___Directors;

var director = new ComputerDirector();

Computer? desktop = director.Construct(new DesktopBuilder());
Console.WriteLine(desktop);

Computer? laptop = director.Construct(new LaptopBuilder());
Console.WriteLine(laptop);

Computer? server = director.Construct(new ServerBuilder());
Console.WriteLine(server);
