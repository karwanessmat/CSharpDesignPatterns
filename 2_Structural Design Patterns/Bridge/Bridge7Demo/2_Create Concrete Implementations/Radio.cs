using Bridge7Demo._1_Define_Implementor_Interface;

namespace Bridge7Demo._2_Create_Concrete_Implementations;

public class Radio : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Radio is turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Radio is turn off");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Radio volume set to {volume}");
    }
}