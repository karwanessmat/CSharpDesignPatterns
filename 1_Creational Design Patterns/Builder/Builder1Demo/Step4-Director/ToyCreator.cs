using Builder1Demo.step1_Product;
using Builder1Demo.Step2_Builder_interface;

namespace Builder1Demo.Step4_Director
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
