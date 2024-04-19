using System;

namespace Adapter1Demo.Step3__Adaptee;

internal class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Inside Adaptee:SpecificRequest() ");
    }
        
}