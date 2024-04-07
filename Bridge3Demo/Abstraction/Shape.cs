using Bridge3Demo.Implementor;

namespace Bridge3Demo.Abstraction
{
  public abstract class Shape(IColor color)
  {
      protected IColor Color = color;

      public abstract void SetColor();
  }
}
