using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory3Demo.Concretes;

namespace Factory3Demo.ConcreteFactory
{
    public class WindowsPlayerCreator:PlayerCreator
    {
        public override Player CreatePlayer()
        {
            return new WindowsPlayer();
        }
    }
}
