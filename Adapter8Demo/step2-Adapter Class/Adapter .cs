namespace Adapter8Demo
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
