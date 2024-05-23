namespace Iterator4Demo.Step1_Iterator_Interface;

public interface IIterator
{
    void First(); // sets current element to the first element.
    string Next(); // advances current to next element.
    bool IsDone(); // check if end of collection
    string CurrentItem(); // returns the current element;
    bool HasNext(); // is like IsDone
}