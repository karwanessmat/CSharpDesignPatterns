namespace Facade6Demo.Subsystem_Classes;

public class HardDrive
{
    public byte[] Read(long lba, int size)
    {
        Console.WriteLine($"Reading {size} bytes from LBA {lba}...");
        return new byte[size]; // Dummy data
    }
}