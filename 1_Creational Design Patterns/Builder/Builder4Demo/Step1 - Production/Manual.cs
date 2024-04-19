namespace Builder4Demo.Step1___Production;

public class Manual
{
    public int Seats { get; set; }
    public string EngineInstructions { get; set; }
    public string TripComputerInstructions { get; set; }
    public string GPSInstructions { get; set; }

    // This method is an example of how you might represent the manual's content as a string.
    public override string ToString()
    {
        return $"Car Manual: \nSeats: {Seats}\nEngine Instructions: {EngineInstructions}\n" +
               $"Trip Computer: {TripComputerInstructions}\nGPS: {GPSInstructions}";
    }
}