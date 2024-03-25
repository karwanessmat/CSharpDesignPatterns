namespace Composite2Demo.Component
{
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    internal abstract class DrawingElement
    {

        protected string Name;

        protected DrawingElement(string name)
        {
            Name = name;
        }


        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);

    }
}
