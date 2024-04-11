namespace Iterator2Demo.Step1_Iterator_Interface
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    internal interface IAbstractIterator

    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
