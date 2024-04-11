namespace Iterator00Demo.Step1_Iterator_Interface;

internal interface IIterator
{
    bool MoveNext();
    int GetCurrent();
}