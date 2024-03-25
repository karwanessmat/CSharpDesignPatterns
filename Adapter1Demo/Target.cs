using System;

namespace Adapter1Demo
{
    internal abstract class Target
    {
        public abstract void Request();
    }

    internal class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Inside Adaptee:SpecificRequest() ");
        }
        
    }

    internal class  Adapter:Target
    {
        private Adaptee adaptee;

        public Adapter( )
        {
            this.adaptee = new Adaptee();
        }

        public override void Request()
        {
            Console.WriteLine("Inside Adapter: Request()");
            adaptee.SpecificRequest();
        }
    }
}
