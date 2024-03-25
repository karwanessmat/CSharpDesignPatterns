using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1Demo
{
    /// <summary>
    /// The Prototype abstract class
    /// </summary>
    internal abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }
}
