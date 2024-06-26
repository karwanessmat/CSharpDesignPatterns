﻿using Template7Demo.AbstractClass;
using Template7Demo.services;

namespace Template7Demo.ConcreteClass;

public class PieBakingService(LoggerAdapter logger) : PanFoodServiceBase<Pie>(logger)
{
    protected override void PrepareCrust()
    {
        _logger.Log("Rolling out crust and pressing into pie pan");
    }

    protected override void AddToppings()
    {
        _logger.Log("Adding pie filling");
    }

    protected override void Cover()
    {
        _logger.Log("Adding lattice top");
    }

    protected override void Bake()
    {
        _logger.Log("Baking for 45 minutes");
    }

    protected override void Slice()
    {
        _logger.Log("Cutting into 6 slices.");
    }

}