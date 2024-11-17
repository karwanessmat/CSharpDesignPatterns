using Bridge7Demo._1_Define_Implementor_Interface;
using Bridge7Demo._3_Define_Abstraction;

namespace Bridge7Demo._4_Create_Refined_Abstraction;


// Refined Abstraction
public class BasicRemote(IDevice device) : RemoteControl(device)
{
    /// <summary>
    /// Get Device (Device.TurnOn();) from RemoteControl
    /// </summary>
    public override void TurnOn() => Device.TurnOn();
    public override void TurnOff() => Device.TurnOff();
    public override void SetVolume(int volume) => Device.SetVolume(volume);
}

// Another Refined Abstraction