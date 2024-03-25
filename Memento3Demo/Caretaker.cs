using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento3Demo
{
    /// <summary>
    ///  Caretaker  (Caretaker)
    /// - is responsible for the memento's safekeeping
    /// - never operates on or examines the contents of a memento.
    /// </summary>

   public class Caretaker
    {
        // Gets or sets memento
        public Memento Memento { set; get; }
    }
}
