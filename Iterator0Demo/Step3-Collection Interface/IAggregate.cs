using Iterator0Demo.Step1_Iterator_Interface;

namespace Iterator0Demo.Step3_Collection_Interface;

internal interface IAggregate
{
    IIterator CreateIterator();
}