using System.Collections.Generic;

namespace Prototype1Demo
{
    internal class SandwichMenu
    {
        private readonly Dictionary<string, SandwichPrototype> _sandwiches
            = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get => _sandwiches[name];
            set => _sandwiches.Add(name, value);
        }
    }
}
