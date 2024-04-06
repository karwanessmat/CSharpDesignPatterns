namespace Adapter2Demo;

public  class  Adapter:ITarget
{
    private Adaptee adaptee;

    //public Adapter()
    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }
    public string Request()
    {
        return $"this is from {adaptee.SpecificRequest()}";
    }
}