using Adapter8Demo.Step1___Interface;
using Adapter8Demo.Step3_Client___Adaptee;

namespace Adapter8Demo.step2_Adapter_Class
{
    public class Adapter:Adaptee, ITarget
    {
        public void SomeMethod()
        {
            // Translate the method call to the incompatible method
            IncompatibleMethod();
        }
    }
}
