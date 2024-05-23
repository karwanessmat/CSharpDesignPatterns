﻿using System;
using Strategy1Demo._1_Define_Strategy_Interface;

namespace Strategy1Demo._2_Concrete_Strategies;

class ConcreteStrategyB:Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public override void AlgorithmInterface()
    {
        Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
    }
}