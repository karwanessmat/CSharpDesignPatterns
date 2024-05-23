using System;

namespace Template1Demo._1_AbstractClass;

public abstract  class AbstractClass
{
    public abstract void Operation1();
    public abstract void Operation2();

    public void TemplateMethod()
    {
        Operation1();
        Operation2();
        Console.WriteLine("");
    }
}