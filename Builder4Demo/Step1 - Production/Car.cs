namespace Builder4Demo.Step1___Production;
public class Car
{
    public int Seats { get; set; }
    public Engine Engine { get; set; }
    public bool HasTripComputer { get; set; }
    public bool HasGPS { get; set; }

    // This method is an example of how you might represent the car's configuration as a string.
    public override string ToString()
    {
        return $"Car with {Seats} seats, Engine power: {Engine.Power}, " +
               $"Trip Computer: {(HasTripComputer ? "Yes" : "No")}, GPS: {(HasGPS ? "Yes" : "No")}";
    }
}
