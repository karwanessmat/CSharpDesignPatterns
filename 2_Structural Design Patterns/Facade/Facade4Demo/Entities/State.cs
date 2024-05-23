namespace Facade4Demo.Entities;

public class State
{
    public State GetStateForZipCode(string zipCode)
    {
        // service or db lookup would go here
        return new State();
    }

    public string Name => "Washington";
}