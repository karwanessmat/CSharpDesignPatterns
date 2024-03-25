using Bridge1Demo.Implementor;

namespace Bridge1Demo.Abstraction
{

  public abstract  class Shape
  {
      protected IDraw drawapi;

      protected Shape(IDraw draw)
      {
          this.drawapi = draw;
      }

      public abstract void Draw();
  }
}
