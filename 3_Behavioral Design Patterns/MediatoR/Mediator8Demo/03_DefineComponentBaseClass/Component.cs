using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator8Demo._01_DefineMediatorInterface;

namespace Mediator8Demo._03_DefineComponentBaseClass;

public abstract class Component(IMediator mediator)
{
    protected IMediator Mediator = mediator;
}