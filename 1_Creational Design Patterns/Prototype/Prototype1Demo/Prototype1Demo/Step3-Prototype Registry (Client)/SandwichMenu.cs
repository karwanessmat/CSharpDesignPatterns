using System.Collections.Generic;
using Prototype1Demo.Step1_Prototype_interface;

namespace Prototype1Demo.Step3_Prototype_Registry__Client_
{
    internal class SandwichMenu
    {
        private readonly Dictionary<string, SandwichPrototype> _sandwiches = new();

        public SandwichPrototype this[string name]
        {
            get => _sandwiches[name];
            set => _sandwiches.Add(name, value);
        }
    }
}
