using Bridge7Demo._1_Define_Implementor_Interface;
using Bridge7Demo._3_Define_Abstraction;

namespace Bridge7Demo._4_Create_Refined_Abstraction;

public class AdvancedRemote(IDevice device) : RemoteControl(device)
{
    public override void TurnOn() => Device.TurnOn();
    public override void TurnOff() => Device.TurnOff();
    public override void SetVolume(int volume) => Device.SetVolume(volume);

    public void Mute() => Console.WriteLine("Device is muted.");
}