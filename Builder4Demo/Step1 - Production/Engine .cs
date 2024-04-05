namespace Builder4Demo.Step1___Production;

public class Engine(string type, int power)
{
    public string Type { get; set; } = type; // Type of engine (e.g., "Sport", "SUV")
    public int Power { get; set; } = power; // Horsepower

    // Constructor for Engine might take parameters to define the type and power.

    // Method to represent the engine's properties as a string.
    public override string ToString()
    {
        return $"Engine Type: {Type}, Power: {Power} HP";
    }
}