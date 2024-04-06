using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter7Demo
{
    // Client code
    internal class Client(IAdapter adapter)
    {
        public void DoWork()
        {
            adapter.SomeMethod();
        }
    }
}
