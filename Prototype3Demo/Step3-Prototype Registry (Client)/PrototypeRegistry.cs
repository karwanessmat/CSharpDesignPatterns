using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype3Demo.Step1_Prototype_interface;

namespace Prototype3Demo.Step3_Prototype_Registry__Client_
{
    public class PrototypeRegistry
    {
        private readonly Dictionary<string, IPrototype> _items = new();

       public void AddItem(string id, IPrototype prototype)
        {
            _items[id] = prototype;
        }
        public IPrototype GetById(string id)
        {
            return _items[id].Clone();
        }

        public IPrototype? GetByColor(string color)
        {
            return (from item in _items.Values 
                    where item.GetColor() == color 
                    select item.Clone())
                .FirstOrDefault();
        }

    }
}
