using Iterator2Demo.collection;

namespace Iterator2Demo.Iterator_AbstractIterator_
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
