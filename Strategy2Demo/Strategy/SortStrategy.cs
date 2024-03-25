using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2Demo.Strategy
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
   public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
