using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento1Demo
{
    public class Memento
    {
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            _state = state;
        }
    }
}
