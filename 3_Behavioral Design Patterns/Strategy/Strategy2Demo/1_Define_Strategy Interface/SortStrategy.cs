using System.Collections.Generic;

namespace Strategy2Demo._1_Define_Strategy_Interface
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
   public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
