using Builder1Demo.step1_Product;
using Builder1Demo.Step2_Builder_interface;

namespace Builder1Demo.Step3_ConcreteBuilder;

public  class ToyBBuilder: IToyBuilder
{
    private readonly Toy _toy = new Toy();
    public void SetModel()
    {
        _toy.Model = "B Model";
    }

    public void SetHead()
    {
        _toy.Head = "B Head";
    }

    public void Body()
    {
        _toy.Body = "B No Steel";
    }

    public void Legs()
    {
        _toy.Legs = "2 Legs";
    }

    public Toy Toy()
    {
        return _toy;
    }
}