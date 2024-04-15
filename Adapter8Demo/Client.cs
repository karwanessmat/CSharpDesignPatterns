using Adapter8Demo.Step1___Interface;

namespace Adapter8Demo
{
    public class Client(ITarget target)
    {
        public void DoWork()
        {
            target.SomeMethod();
        }
    }
}


//In this code, the Adapter is able to convert the Target interface method call
//into an Adaptee method call, thus making it possible for the Client to work with
//Adaptee through the Target interface without changing Client or Adaptee