using Builder1Demo.Builder;
using Builder1Demo.ConcreteBuilder;
using Builder1Demo.Product;

namespace Builder1Demo.Director
{
  public  class ToyCreator
  {
      private readonly IToyBuilder _toyBuilder;

      public ToyCreator(IToyBuilder toyBuilder)
      {
          this._toyBuilder = toyBuilder;
      }

      public void CreateToy()
      {
          _toyBuilder.SetModel();
          _toyBuilder.SetHead();
          _toyBuilder.Body();
          _toyBuilder.Legs();
      }


      public Toy GetToy()
      {
          return _toyBuilder.Toy();
      }
  }
}
