using Adapter2Demo.step1___Client_Interface;
using Adapter2Demo.Step3__Adaptee;

namespace Adapter2Demo.step2_Adapter_Class;

public class Adapter(Adaptee adaptee) : ITarget
{
    //public Adapter()
    public string Request()
    {
        return $"this is from {adaptee.SpecificRequest()}";
    }
}