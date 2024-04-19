using Iterator2Demo.Step2_Concrete_Iterator;

namespace Iterator2Demo.Step3_Collection_Interface
{

    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    internal interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
