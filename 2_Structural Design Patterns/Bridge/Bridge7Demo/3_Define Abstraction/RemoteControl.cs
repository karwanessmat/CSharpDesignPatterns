using Bridge7Demo._1_Define_Implementor_Interface;

namespace Bridge7Demo._3_Define_Abstraction;

//Abstraction
public abstract class RemoteControl(IDevice device)
{
    protected IDevice Device = device;

    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void SetVolume(int volume);
}