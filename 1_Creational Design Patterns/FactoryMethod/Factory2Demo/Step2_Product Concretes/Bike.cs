﻿using System;
using Factory2Demo.Step1_Product_Interface;

namespace Factory2Demo.Step2_Product_Concretes;

public  class Bike:IVehicle
{
    public void Drive(int km)
    {
        Console.WriteLine($"Drive {km} by bike");
    }
}