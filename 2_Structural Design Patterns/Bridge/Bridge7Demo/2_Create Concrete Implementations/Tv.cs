using Bridge7Demo._1_Define_Implementor_Interface;

namespace Bridge7Demo._2_Create_Concrete_Implementations;


// Concrete Implementation

public class Tv:IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Tv is turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Tv is turn off");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Tv volume set to {volume}");
    }
}