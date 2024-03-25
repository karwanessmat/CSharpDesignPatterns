using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State1Demo
{
    public class ConcreteStateB:State
    {
        public override void Handler(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
