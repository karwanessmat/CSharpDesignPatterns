// Logger instance to capture output
using Template7Demo.ConcreteClass;
using Template7Demo.services;

var logger = new LoggerAdapter();

// Service for baking pizza
var pizzaService = new PizzaBakingService(logger);
var pizza = pizzaService.Prepare(); // Prepare the pizza
Console.WriteLine("Pizza preparation log:");
Console.WriteLine(logger.Dump());
Console.WriteLine($"Pizza was baked: {pizza.WasBaked}, Number of slices: {pizza.NumSlices}");
Console.WriteLine();

// Clear the logger for the next service
logger = new LoggerAdapter();

// Service for preparing a cold veggie pizza
var coldVeggiePizzaService = new ColdVeggiePizzaBakingService(logger);
var coldVeggiePizza = coldVeggiePizzaService.Prepare(); // Prepare the cold veggie pizza
Console.WriteLine("Cold Veggie Pizza preparation log:");
Console.WriteLine(logger.Dump());
Console.WriteLine("No baking required for Cold Veggie Pizza.");

Console.ReadLine(); // Keep console open to read output