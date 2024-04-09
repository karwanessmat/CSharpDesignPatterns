namespace Adapter2Demo;

public class Adapter(Adaptee adaptee) : ITarget
{
    //public Adapter()
    public string Request()
    {
        return $"this is from {adaptee.SpecificRequest()}";
    }
}