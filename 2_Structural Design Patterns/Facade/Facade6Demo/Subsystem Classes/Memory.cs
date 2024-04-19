namespace Facade6Demo.Subsystem_Classes;

public class Memory
{
    public void Load(long position, byte[] data)
    {
        Console.WriteLine($"Loading data to position {position}...");
    }
}