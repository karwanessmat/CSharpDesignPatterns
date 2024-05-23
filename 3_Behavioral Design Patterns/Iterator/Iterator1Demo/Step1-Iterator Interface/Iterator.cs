namespace Iterator1Demo.Step1_Iterator_Interface;

/// <summary>
/// The 'Iterator' abstract class
/// </summary>
public abstract class Iterator

{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
    public abstract bool HasNext();
}