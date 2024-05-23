using Adapter7Demo.Step1___Interface;
using Adapter7Demo.Step3_Client___Adaptee;

namespace Adapter7Demo.step2_Adapter_Class;

public class SpecificAdapter(Adaptee adaptee):IAdapter
{

    public void SomeMethod()
    {
        adaptee.IncompatibleMethod();
    }
}