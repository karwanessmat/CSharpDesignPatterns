using Bridge1Demo.Implementor;

namespace Bridge1Demo.Abstraction
{

  public abstract class Shape(IDraw draw)
  {

      /// <summary>
      /// this is a bridge
      /// </summary>
      protected IDraw DrawApi = draw;

      public abstract void Draw();
  }
}
