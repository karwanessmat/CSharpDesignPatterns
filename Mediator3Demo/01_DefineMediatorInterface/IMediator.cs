using Mediator3Demo._03_DefineComponentBaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator3Demo._01_DefineMediatorInterface;

public interface IMediator
{
    void Notify(Control sender, string @event);
}
