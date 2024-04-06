namespace Adapter7Demo
{
    public class SpecificAdapter(Adaptee adaptee):IAdapter
    {

        public void SomeMethod()
        {
            adaptee.IncompatibleMethod();
        }
    }
}
