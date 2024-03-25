using System;
using System.Collections.Generic;
using System.Text;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.Abstraction
{
  public abstract class Shape
  {
      protected IColor Color;

      protected Shape(IColor color)
      {
          Color = color;
      }

      public abstract void SetColor();
  }
}
