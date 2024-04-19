using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator8Demo._01_DefineMediatorInterface;

public interface IMediator
{
    void Notify(object sender, string event_);
}