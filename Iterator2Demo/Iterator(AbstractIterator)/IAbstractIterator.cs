using Iterator2Demo.collection;

namespace Iterator2Demo
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    internal interface IAbstractIterator

    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
