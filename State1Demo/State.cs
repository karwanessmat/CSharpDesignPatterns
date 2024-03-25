using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State1Demo
{

    /// <summary>
    /// the 'State' abstract class
    /// </summary>
    public abstract class State
    {
        public abstract void Handler(Context context);
    }
}
