using Iterator00Demo.Step1_Iterator_Interface;

namespace Iterator00Demo.Step3_Collection_Interface;

internal interface IAggregate
{
    IIterator CreateIterator();
    void Insert(int value);
}