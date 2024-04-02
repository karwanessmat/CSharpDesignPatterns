using Iterator2Demo.ConcreteIterator_Iterator_;

namespace Iterator2Demo.Aggregate_AbstractCollection_
{

    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    internal interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
