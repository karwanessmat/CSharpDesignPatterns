using Bridge3Demo._1_Define_Implementor_Interface;

namespace Bridge3Demo._3_Define_Abstraction
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
