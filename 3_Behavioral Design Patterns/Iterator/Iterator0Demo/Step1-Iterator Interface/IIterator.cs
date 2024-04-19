namespace Iterator0Demo.Step1_Iterator_Interface;

public interface IIterator
{
    bool HasNext();
    object? Next();
}