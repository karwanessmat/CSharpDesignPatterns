using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator3Demo._01_DefineMediatorInterface;

namespace Mediator3Demo._03_DefineComponentBaseClass;

public abstract class Control(IMediator mediator)
{
    protected IMediator Mediator = mediator;


}
