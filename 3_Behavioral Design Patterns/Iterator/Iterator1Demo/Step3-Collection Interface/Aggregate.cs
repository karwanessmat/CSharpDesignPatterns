using Iterator1Demo.Step1_Iterator_Interface;

namespace Iterator1Demo.Step3_Collection_Interface;

/// <summary>
/// The 'Aggregate' abstract class
/// </summary>
internal abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}