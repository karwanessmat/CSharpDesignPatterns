using Prototype3Demo.Step2_ConcretePrototypes;
using Prototype3Demo.Step3_Prototype_Registry__Client_;

// Initialize the Prototype Registry
PrototypeRegistry registry = new();

// Create a new Button prototype and add it to the registry
var landingButton = new Button(2,3,"Red");
registry.AddItem(nameof(landingButton),landingButton);

// Retrieve a clone of the button by color
var clonedRedButton = (Button)registry.GetByColor("Red");
Console.WriteLine($"Cloned Button: X={clonedRedButton.X}, Y={clonedRedButton.Y}, Color={clonedRedButton.Color}");
