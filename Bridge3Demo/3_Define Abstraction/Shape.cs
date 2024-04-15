using Bridge3Demo.Implementor;

namespace Bridge3Demo.Abstraction
{
  public abstract class Shape(IColor color)
  {
      /// <summary>
      /// it is bridge
      /// </summary>
      protected IColor Color = color;

      public abstract void SetColor();
  }
}
