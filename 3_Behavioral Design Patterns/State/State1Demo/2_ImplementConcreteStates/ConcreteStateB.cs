﻿using State1Demo._1_CreateStateInterface;
using State1Demo._3_ContextClass;

namespace State1Demo._2_ImplementConcreteStates;

public class ConcreteStateB:State
{
    public override void Handler(Context context)
    {
        context.State = new ConcreteStateA();
    }
}