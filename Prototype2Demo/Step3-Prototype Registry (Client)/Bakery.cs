﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype2Demo.Step2_ConcretePrototypes;

namespace Prototype2Demo.Step3_Prototype_Registry__Client_
{
    public class Bakery
    {
        public void MakeCookie()
        {
            // Create an initial circle shape
            CircleCookie originalCircleCookie = new(10);

            // Use the shape cutter to make a new shape
            CircleCookie clonedCircleCookie = (CircleCookie)originalCircleCookie.Clone();
            Console.WriteLine($"Cloned a circle cookie with diameter: {clonedCircleCookie.Diameter}");

            // Create an initial square cookie
            SquareCookie originalSquareCookie = new(3);

            // Use the cookie cutter to make a new cookie
            SquareCookie clonedSquareCookie = (SquareCookie)originalSquareCookie.Clone();
            Console.WriteLine($"Cloned a square cookie with side length: {clonedSquareCookie.SideLength}");





        }
    }
}