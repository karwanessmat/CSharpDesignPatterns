using System;
using Factory1Demo.Step1_Product_Interface;

namespace Factory1Demo.Step2_Product_Concretes;

public class Square:IShape
{
    public void Draw()
    {
        Console.WriteLine("Shape of Square");
    }
}