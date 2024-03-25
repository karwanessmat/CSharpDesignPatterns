using System;
using System.Collections.Generic;
using System.Text;

namespace Composite1Demo
{

    /// <summary>
    /// The 'Component' abstract class
    /// </summary>

    public abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }


        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }


    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Composite:Component
    {
        private readonly List<Component> _children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+Name);
            foreach (var component in _children)
            {
                component.Display(depth+2);
            }
        }
    }


    public  class  Leaf:Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Con not add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Con not remove to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
