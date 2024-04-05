using Builder1Demo.Product;
using Builder1Demo.Step1_Builder;

namespace Builder1Demo.ConcreteBuilder
{
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
}
