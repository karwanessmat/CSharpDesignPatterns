var director = new ComputerDirector();

var desktopBuilder = new DesktopBuilder();
var desktop = director.Construct(desktopBuilder);
Console.WriteLine(desktop);

var laptopBuilder = new LaptopBuilder();
var laptop = director.Construct(laptopBuilder);
Console.WriteLine(laptop);

var serverBuilder = new ServerBuilder();
var server = director.Construct(serverBuilder);
Console.WriteLine(server);