using System;
using Adapter1Demo.step1___Client_Interface;
using Adapter1Demo.Step3__Adaptee;

namespace Adapter1Demo.step2_Adapter_Class;

internal class  Adapter:Target
{
    private readonly Adaptee _adaptee = new();

    public override void Request()
    {
        Console.WriteLine("Inside Adapter: Request()");
        _adaptee.SpecificRequest();
    }
}