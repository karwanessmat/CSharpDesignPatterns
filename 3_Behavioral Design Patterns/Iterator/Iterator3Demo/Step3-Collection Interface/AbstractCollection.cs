using Iterator3Demo.Step1_Iterator_Interface.IteratorDesignPattern;

namespace Iterator3Demo.Step3_Collection_Interface;

public interface IAbstractCollection
{
    IAbstractIterator CreateIterator();
}