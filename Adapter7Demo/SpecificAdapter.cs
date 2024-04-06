using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter7Demo
{
    public class SpecificAdapter(Adaptee adaptee):IAdapter
    {

        public void SomeMethod()
        {
            adaptee.IncompatibleMethod();
        }
    }
}
