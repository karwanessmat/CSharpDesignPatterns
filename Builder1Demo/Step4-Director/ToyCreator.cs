using Builder1Demo.Product;
using Builder1Demo.Step1_Builder;

namespace Builder1Demo.Director
{
  public  class ToyCreator(IToyBuilder toyBuilder)
  {

      public void CreateToy()
      {
          toyBuilder.SetModel();
          toyBuilder.SetHead();
          toyBuilder.Body();
          toyBuilder.Legs();
      }


      public Toy GetToy()
      {
          return toyBuilder.Toy();
      }
  }
}
